using MTG.ArgumentDefintions.Event_Arguments;
using MTG.ArgumentDefintions.Trigger_Arguments;
using MTG.DTO.Objects;
using MTG.DTO.Responses;
using MTG.Enumerations;
using MTG.Helpers;
using MTG.Interfaces;
using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Static;
using MTG.Model.Counters;
using MTG.Model.Effects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model.Objects
{
    public class Card
    {
        #region Events
        public event EventHandler OnCardEvent, OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnApplyDamage;
        #endregion

        #region Variables
        private bool _PhasedOut, _Tapped;
        private List<IAbility> _Abilities;
        private List<CardType> _CardTypes;
        private List<Colors> _Colors;
        private List<ICounter> _Counters;
        private List<int> _Damage;
        private List<SubType> _SubTypes;
        private List<SuperType> _SuperTypes;
        private int _Power, _Toughness;
        #endregion

        #region Properties - Collections
        public IReadOnlyList<IAbility> Abilities { get { return _Abilities.AsReadOnly(); } }
        public IReadOnlyList<CardType> CardTypes { get { return _CardTypes.AsReadOnly(); } }
        public IReadOnlyList<Colors> Colors { get { return _Colors.AsReadOnly(); } }
        public IReadOnlyList<ICounter> Counters { get { return _Counters.AsReadOnly(); } }
        public IReadOnlyList<int> Damage { get { return _Damage.AsReadOnly(); } }
        public IReadOnlyList<SubType> SubTypes { get { return _SubTypes.AsReadOnly(); } }
        public IReadOnlyList<SuperType> SuperTypes { get { return _SuperTypes.AsReadOnly(); } }

        #endregion

        #region Properties
        public CastingCost CastingCost { get; set; }
        public Guid ControllerId { get; set; }
        public Guid Id { get; private set; }
        public string ImageUrl { get { return "/"+ MultiverseId; } }
        internal int MultiverseId { get; set; }
        public string Name { get; set; }
        public Guid OwnerId { get; set; }
        public bool PhasedOut
        {
            get { return _PhasedOut; }
            set
            {
                _PhasedOut = value;
                OnCardEvent?.Invoke(this, new PhaseCardEventArgs() { CardId = Id, ControllerId= ControllerId, PhaseIn = !value});
            }
        }
        public int Power
        {
            get
            {
                int retVal = _Power;
                foreach (ICounter counter in _Counters)
                    if (counter is PlusXPlusY)
                        retVal += ((PlusXPlusY)counter).X;
                return retVal < 0 ? 0 : retVal;
            }
        }
        public bool Tapped
        {
            get { return _Tapped; }
            set
            {
                _Tapped = value;
                OnEffectTrigger?.Invoke(null, new EffectTriggerEventArgs()
                {
                    Args = new TappingTriggerArgs()
                    {
                        ActiveCard = this,
                        TappingType = value ? TappingTypes.Tapped: TappingTypes.UnTapped,
                    },
                    Trigger = EffectTrigger.Card_Tapping,
                });
            }
        }
        public bool SummoningSickness { get; set; }
        public int Toughness
        {
            get
            {
                int retVal = _Toughness;
                foreach (ICounter counter in _Counters)
                    if (counter is PlusXPlusY)
                        retVal += ((PlusXPlusY)counter).Y;
                return retVal < 0 ? 0: retVal;
            }
        }
        #endregion

        #region Constructors
        public Card()
        {
            Id = Guid.NewGuid();
            _Abilities = new List<IAbility>();
            _CardTypes = new List<CardType>();
            _Colors = new List<Colors>();
            _Counters = new List<ICounter>();
            _Damage = new List<int>();
            _SubTypes = new List<SubType>();
            _SuperTypes = new List<SuperType>();
            CastingCost = new CastingCost();
        }
        public Card(int power, int toughness):this()
        {
            _Power = power;
            _Toughness = toughness;
        }
        public Card(Card card):this()
        {
            _Abilities = card.Abilities.ToList();
            _CardTypes = card.CardTypes.ToList();
            _Colors = card.Colors.ToList();
            _Counters = card.Counters.ToList();
            _Damage = card.Damage.ToList();
            _SubTypes = card.SubTypes.ToList();
            _SuperTypes = card.SuperTypes.ToList();
            _Power = card.Power;
            _Toughness = card.Toughness;
            CastingCost = card.CastingCost;
            Id = Guid.NewGuid();
            ImageUrl = card.ImageUrl;
            Name = card.Name;
            OwnerId = card.OwnerId;
        }
        #endregion

        #region Operators
        public static bool operator ==(Card x, Card y)
        {
            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
                return ReferenceEquals(y, null) && ReferenceEquals(x, null);
            return x.Equals(y);
        }
        public static bool operator !=(Card x, Card y)
        {
            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
                return !(ReferenceEquals(y, null) && ReferenceEquals(x, null));
            return !(x == y);
        }
        #endregion

        #region Event Handlers
        private void Ability_EffectTrigger(object sender, EventArgs e)
        {
            OnEffectTrigger?.Invoke(this, e);
        }
        private void Ability_EffectTriggered(object sender, EventArgs e)
        {
            OnEffectTriggered?.Invoke(this, e);
        }
        private void Ability_PendingActionTriggered(object sender, EventArgs e)
        {
            OnPendingActionTriggered?.Invoke(this, e);
        }
        private void Ability_OnCardEvent(object sender, EventArgs e)
        {
            ICardEventArgs args = (ICardEventArgs)e;
            if (args.CardId == Id)
                Apply(args);
            else
                OnCardEvent?.Invoke(this, e);
        }
        #endregion

        #region Methods
        public SelectAbilityResponse ActivateAbility(Guid abilityId, ManaPool pool, IActivationArgs args)
        {
            SelectAbilityResponse retVal = new SelectAbilityResponse();
            IActivatedAbility ability = (IActivatedAbility)_Abilities.FirstOrDefault(o => o.Id == abilityId);
            if (ability.RequiresTap && Tapped)
                retVal.Message = "Card is already Tapped.";
            else
            {
                List<Guid> castingMana = new List<Guid>();
                if (Mana_Helper.CanActivate(ability.ActivationCost, ability, pool, ref castingMana))
                {
                    pool.UseMana(castingMana);
                    AddAbilityHooks(ability);
                    ability.Activate(args);
                    RemoveAbilityHooks(ability);
                    retVal.Success = true;
                }
                else
                    retVal.Message = "Insufficient mana in the pool";
            }
            return retVal;
        }
        public void Add(IAbility ability)
        {
            _Abilities.Add(ability);
        }
        public void Add(ICounter counter)
        {
            _Counters.Add(counter);
            OnEffectTrigger?.Invoke(null, new EffectTriggerEventArgs()
            {
                Args = new CounterTriggerArgs()
                {
                    ActiveCard = this,
                    Counter = counter,
                },
                Trigger = EffectTrigger.Card_RecievesCounter,
            });
        }
        public void Add(CardType cardType)
        {
            _CardTypes.Add(cardType);
        }
        public void Add(Colors color)
        {
            _Colors.Add(color);
        }
        public void Add(IEffect effect)
        {
            if (effect is DamageEffect)
            {
                ((DamageEffect)effect).Damage.OnApplyDamage += OnApplyDamage;
                ((DamageEffect)effect).Damage.Process(effect.Target);
                ((DamageEffect)effect).Damage.OnApplyDamage -= OnApplyDamage;
            }
            else
                throw new NotImplementedException("Card.Add Effect: Undefined for " + effect.ToString());
        }
        public void Add(SubType subType)
        {
            _SubTypes.Add(subType);
        }
        public void Add(SuperType superType)
        {
            _SuperTypes.Add(superType);
        }
        public void AddAbilityHooks(IAbility ability)
        {
            ability.OnEffectTrigger += Ability_EffectTrigger;
            ability.OnEffectTriggered += Ability_EffectTriggered;
            ability.OnPendingActionTriggered += Ability_PendingActionTriggered;
            ability.OnCardEvent += Ability_OnCardEvent;
        }
        public void Apply(ICardEventArgs args)
        {
            if (args is TapCardEventArgs)
                Tapped = ((TapCardEventArgs)args).Tapped;
            else
                throw new Exception("Cannot apply the event from " + args.ToString());
        }
        public void ApplyDamage(ApplyDamageEventArgs args)
        {
            if (HasType(CardType.Planeswalker))
            {
                for (int i = 0; i < args.DamageValue; i++)
                    Remove(typeof(Loyalty));
            }
            else
            {
                if (args.Types.Contains(DamageTypes.Trample) && args.DamageValue > Toughness)
                {
                    _Damage.Add(Toughness);
                    ApplyDamageEventArgs trampleArgs = new ApplyDamageEventArgs()
                    {
                        DamageValue = args.DamageValue - Toughness,
                        Target = new Target() { Type = TargetType.Player, Id = ControllerId },
                    };
                    trampleArgs.addDamageAttributtes(DamageTypes.Blocked);
                    OnApplyDamage?.Invoke(this, trampleArgs);
                }
                else
                    _Damage.Add(args.DamageValue);
                if (args.Types.Contains(DamageTypes.Deathtouch) && args.DamageValue > 0)
                    Destroy();
                else
                {
                    int totalDamage = 0;
                    foreach (int damage in Damage)
                        totalDamage += damage;
                    if (totalDamage >= Toughness)
                        Destroy();
                }
            }
        }
        public void CheckTriggeredAbilities(EffectTrigger trigger, ITriggeredAbilityArgs args = null)
        {
            if (trigger == EffectTrigger.None)
                return;
            foreach (IAbility ability in _Abilities.FindAll(o => o is ITriggeredAbility &&  ((ITriggeredAbility)o).Trigger == trigger))
                ((ITriggeredAbility)ability).Process(ArgsHelper.GenerateTriggeredAbilityArgs());
        }
        public void ClearDamage()
        {
            _Damage.Clear();
        }
        public void Destroy()
        {
            if (!HasAbility(typeof(Indestructible)))
            {
                _Counters.Clear();
                _Damage.Clear();
                OnEffectTrigger?.Invoke(this, new EffectTriggerEventArgs()
                {
                    Args = new DestroyedTriggerArgs()
                    {
                        ActiveCard = this,
                    },
                    Trigger = EffectTrigger.Card_Destroyed,
                });
                OnCardEvent?.Invoke(this, new DestroyCardEventArgs() { CardId = Id, ControllerId = ControllerId });
            }
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Card)) return false;  
            return Id == ((Card)obj).Id;
        }
        public List<T> FilteredAbilities<T>()
        {
            return _Abilities.Where(o => o is T).Cast<T>().ToList();
        }
        public Target GenerateTarget()
        {
            return new Target()
            {
                Type = HasType(CardType.Planeswalker)? TargetType.Planeswalker: TargetType.Card,
                Id = Id,
            };
        }
        public GetSpellOptionsResponse GetSpellOptions()
        {
            List<SelectableAbility> selectableAbilities = new List<SelectableAbility>();
            foreach (ICastingAbility ability in FilteredAbilities<ICastingAbility>())
                selectableAbilities.Add(new SelectableAbility()
                {
                    AbilityId = ability.Id,
                    CanTarget = ability.TargetTypes,
                    RequiresTarget = ability.RequiresTarget,
                    Name = Name,
                    TargetScope = ability.TargetScope,
                });
            return new GetSpellOptionsResponse()
            {
                Abilities = selectableAbilities, 
                SelectNumber  = 1,
            };
        }
        public List<ICounter> GetCountersByType(Type type)
        {
            return _Counters.FindAll(o=>o.GetType() == type);
        }
        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
        public bool HasAbility(Type abilityType)
        {
            return _Abilities.FirstOrDefault(o => o.GetType() == abilityType) != null;
        }
        public bool HasCounterType(Type type)
        {
            return _Counters.FirstOrDefault(o => o.GetType() == type) != null;
        }
        public bool HasSubType(SubType subType)
        {
            return _SubTypes.Contains(subType);
        }
        public bool HasType(CardType cardType)
        {
            return _CardTypes.Contains(cardType);
        }
        public void Remove(ICounter counter)
        {
            _Counters.Remove(counter);
        }
        public void Remove(Type type)
        {
            ICounter counter = Counters.FirstOrDefault(o => o.GetType() == type);
            if (counter != null)
                Remove(counter);
        }
        public void RemoveAbilityHooks(IAbility ability)
        {
            ability.OnEffectTrigger -= Ability_EffectTrigger;
            ability.OnEffectTriggered -= Ability_EffectTriggered;
            ability.OnPendingActionTriggered -= Ability_PendingActionTriggered;
            ability.OnCardEvent -= Ability_OnCardEvent;
        }
        public override string ToString()
        {
            return Name + " - " + Id.ToString();
        }
        #endregion
    }
}
