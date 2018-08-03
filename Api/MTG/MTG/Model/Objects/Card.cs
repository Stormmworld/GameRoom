using MTG.ArgumentDefintions;
using MTG.ArgumentDefintions.Trigger_Arguments;
using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model;
using MTG.Model.Abilities;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model.Objects
{
    public class Card
    {
        #region Events
        public event EventHandler OnCardPhasedIn, OnCardPhasedOut, OnCardTapped, OnCardUntapped, OnCardDestroyed, OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Variables
        private bool _PhasedOut, _Tapped;
        private List<IAbility> _Abilities;
        private List<CardType> _CardTypes;
        private List<Colors> _Colors;
        private List<Counter> _Counters;
        private List<SubType> _SubTypes;
        private List<SuperType> _SuperTypes;
        private int _Power, _Toughness;
        #endregion

        #region Properties - Collections
        public IReadOnlyList<IAbility> Abilities { get { return _Abilities.AsReadOnly(); } }
        public IReadOnlyList<CardType> CardTypes { get { return _CardTypes.AsReadOnly(); } }
        public IReadOnlyList<Colors> Colors { get { return _Colors.AsReadOnly(); } }
        public IReadOnlyList<Counter> Counters { get { return _Counters.AsReadOnly(); } }
        public IReadOnlyList<SubType> SubTypes { get { return _SubTypes.AsReadOnly(); } }
        public IReadOnlyList<SuperType> SuperTypes { get { return _SuperTypes.AsReadOnly(); } }
        #endregion

        #region Properties
        public bool CanBeDestroyed { get; set; }
        public Guid ControllerId { get; set; }
        public int DamageTaken { get; set; }
        public int FaceUpSide { get; set; }
        public Guid Id { get; set; }
        public bool HasFirstStrike
        {
           get { return (Abilities.FirstOrDefault(p => p is First_Strike) != null)||(Abilities.FirstOrDefault(p => p is Double_Strike) != null); }
        }
        public bool HasNormalStrike
        {
            get { return Abilities.FirstOrDefault(p => p is First_Strike) == null; }
        }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public Guid OwnerId { get; set; }
        public bool PhasedOut
        {
            get { return _PhasedOut; }
            set
            {
                _PhasedOut = value;
                if (_PhasedOut)
                    OnCardPhasedOut?.Invoke(null, new CardEventArgs() { Card = this });
                else
                    OnCardPhasedIn?.Invoke(null, new CardEventArgs() { Card = this });
            }
        }
        public int Power
        {
            get
            {
                int retVal = _Power;
                foreach (Counter counter in _Counters)
                    if (counter.CounterType == CounterType.PlusXPlusY)
                        retVal += counter.X;
                return retVal < 0 ? 0 : retVal;
            }
        }
        public int PreventDamage { get; set; }
        public bool SufferingFromDeathtouchEffect { get; set; }
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
        public int Toughness
        {
            get
            {
                int retVal = _Toughness;
                foreach (Counter counter in _Counters)
                    if (counter.CounterType == CounterType.PlusXPlusY)
                        retVal += counter.Y;
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
            _Counters = new List<Counter>();
            _SubTypes = new List<SubType>();
            _SuperTypes = new List<SuperType>();
            CanBeDestroyed = true;
        }
        public Card(int power, int toughness):this()
        {
            _Power = power;
            _Toughness = toughness;
        }
        public Card(Card card):this()
        {
            throw new NotImplementedException("Card.Constructor");
        }
        #endregion

        #region Operators
        public static bool operator ==(Card x, Card y)
        {
            return x.Equals(y);
        }
        public static bool operator !=(Card x, Card y)
        {
            return !(x == y);
        }
        #endregion

        #region Event Handlers
        private void Ability_EffectTrigger(object sender, EventArgs e)
        {
            OnEffectTrigger?.Invoke(sender, e);
        }
        private void Ability_EffectTriggered(object sender, EventArgs e)
        {
            OnEffectTriggered?.Invoke(sender, e);
        }
        private void Ability_PendingActionTriggered(object sender, EventArgs e)
        {
            OnPendingActionTriggered?.Invoke(sender, e);
        }
        #endregion

        #region Methods
        public void Add(IAbility ability)
        {
            ability.OnEffectTrigger += Ability_EffectTrigger;
            ability.OnEffectTriggered += Ability_EffectTriggered;
            ability.OnPendingActionTriggered += Ability_PendingActionTriggered;
            _Abilities.Add(ability);
        }
        public void Add(Counter counter)
        {
            _Counters.Add(counter);
            OnEffectTrigger?.Invoke(null, new EffectTriggerEventArgs()
            {
                Args = new CounterTriggerArgs()
                {
                    ActiveCard = this,
                    CounterType = counter.CounterType,
                },
                Trigger = EffectTrigger.Card_RecievesCounter,
            });
        }
        public void Add(CardType cardType)
        {
            _CardTypes.Add(cardType);
        }
        public void Add(SubType subType)
        {
            _SubTypes.Add(subType);
        }
        public void AddDamage(ActiveGame game, int damage, Card originCard)
        {
            if (game.Modifiers.Contains(GameModifier.CreaturesTakeNoDamage))
                return; 
            DamageTaken += damage;
        }
        public void CheckTriggeredAbilities(EffectTrigger trigger, AbilityArgs args = null)
        {
            if (trigger == EffectTrigger.None)
                return;

            foreach (IAbility ability in _Abilities.FindAll(o => o.Trigger == trigger))
                ability.Process(new AbilityArgs() { OriginCard = this });
            throw new NotImplementedException("Card.CheckTriggeredAbilities");// add feed from parameter args
        }
        public void Destroy()
        {        
            if (CanBeDestroyed)
                OnEffectTrigger?.Invoke(this, new EffectTriggerEventArgs()
                {
                    Args = new DestroyedTriggerArgs()
                    {
                        ActiveCard = this,
                    },
                    Trigger = EffectTrigger.Card_Destroyed,
                });
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Card)) return false;  
            return Id == ((Card)obj).Id;
        }
        public List<Counter> GetCountersByType(CounterType type)
        {
            return _Counters.FindAll(o=>o.CounterType == type);
        }
        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
        public bool HasType(CardType cardType)
        {
            return _CardTypes.Contains(cardType);
        }
        public void ProcessDamage()
        {
            if (CardTypes.Contains(CardType.Planeswalker))
            {
                for (int i = 0; i < DamageTaken; i++)
                {
                    Counter loyaltyCounter = Counters.FirstOrDefault(o => o.CounterType == CounterType.Loyalty);
                    if (loyaltyCounter != null)
                        _Counters.Remove(loyaltyCounter);
                }
                if (Counters.FirstOrDefault(o => o.CounterType == CounterType.Loyalty) == null)
                    Destroy();
            }
            else if (SufferingFromDeathtouchEffect ||DamageTaken >= Toughness)
                Destroy();
            DamageTaken = 0;
        }
        public void Remove(Counter counter)
        {
            throw new NotImplementedException("Card.RemoveCounter");
        }
        #endregion
    }
}
