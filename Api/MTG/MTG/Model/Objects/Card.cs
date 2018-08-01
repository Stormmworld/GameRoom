using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model;
using MTG.Model.Abilities;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTGModel.Objects
{
    public class Card
    {
        #region Events
        public event EventHandler OnCardPhasedIn, OnCardPhasedOut, OnCardTapped, OnCardUntapped, OnCardDestroyed, OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Variables
        private bool _PhasedOut, _Tapped;
        private List<Counter> _Counters;
        #endregion

        #region Properties
        public List<IAbility> Abilities { get; set; }
        public List<int> BandedWithCardIds { get; set; }
        public bool CanBeDestroyed { get; set; }
        public List<CardType> CardTypes { get; private set; }
        public List<Colors> Colors { get; set; }
        public int ControllerId { get; set; }
        public IReadOnlyList<Counter> Counters { get { return _Counters.AsReadOnly(); } }
        public int DamageTaken { get; set; }
        public int FaceUpSide { get; set; }
        public int Id { get; set; }
        public bool HasFirstStrike
        {
           get { return Abilities.FirstOrDefault(p => p is First_Strike) != null; }
        }
        public bool HasDoubleStrike
        {
            get { return Abilities.FirstOrDefault(p => p is Double_Strike) != null;}
        }
        public bool HasNormalStrike
        {
            get { return Abilities.FirstOrDefault(p => p is First_Strike) == null; }
        }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
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
        public int Power { get; set; }
        public int PreventDamage { get; set; }
        public bool SelectedToUntap { get; set; }
        public List<SubType> SubTypes { get; set; }
        public bool SufferingFromDeathtouchEffect { get; set; }
        public List<SuperType> SuperTypes { get; set; }
        public bool Tapped
        {
            get { return _Tapped; }
            set
            {
                _Tapped = value;
                if (_Tapped)
                    OnCardTapped?.Invoke(null, new CardEventArgs() { Card = this });
                else
                    OnCardUntapped?.Invoke(null, new CardEventArgs() { Card = this });
            }
        }
        public int Toughness { get; set; }
        public List<TriggeredEffect> TriggeredEffects { get; set; }
        public bool UntapDuringUntapPhase { get; set; }
        public UpkeepTriggers UpkeepTrigger { get; set; }
        public UpkeepRequirement UpkeepRequirement { get; set; }
        public bool IsPermanant
        {
            get
            {
                foreach (CardType type in CardTypes)
                {
                    switch (type)
                    {
                        case CardType.Artifact:
                        case CardType.Creature:
                        case CardType.Enchantment:
                        case CardType.Land:
                        case CardType.Planeswalker:
                            return true;
                    }
                }
                return false;
            }
        }
        #endregion

        #region Constructors
        public Card()
        {
            Abilities = new List<IAbility>();
            CardTypes = new List<CardType>();
            TriggeredEffects = new List<TriggeredEffect>();
            SubTypes = new List<SubType>();
            Colors = new List<Colors>();
            _Counters = new List<Counter>();
         _PhasedOut = false;
            SelectedToUntap = false;
            _Tapped = false;
            UntapDuringUntapPhase = true;
        }
        public Card(Card card):this()
        {
            for (int i = 0; i < card.Abilities.Count; i++)
                Abilities.Add(card.Abilities[i]);
            for (int i = 0; i < card.CardTypes.Count; i++)
                CardTypes.Add(card.CardTypes[i]);
            _PhasedOut = card.PhasedOut;
            SelectedToUntap = card.SelectedToUntap;
            _Tapped = card.Tapped;
            UntapDuringUntapPhase = card.UntapDuringUntapPhase;
            TriggeredEffects = card.TriggeredEffects;
            SubTypes = card.SubTypes;
            Colors = card.Colors;
            Power = card.Power;
            Toughness = card.Toughness;
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
            ability.OnEffectTriggered += Ability_EffectTriggered;
            ability.OnPendingActionTriggered += Ability_PendingActionTriggered;
            Abilities.Add(ability);
        }
        public void Add(Counter counter)
        {
            throw new NotImplementedException("Card.AddCounter");
        }
        public void AddDamage(ActiveGame game, int damage, Card originCard)
        {
            if (game.Modifiers.Contains(GameModifier.CreaturesTakeNoDamage))
                return;

            foreach (IAbility ability in Abilities.FindAll(o => o.Trigger == EffectTrigger.RecievesDamage))
            {
                ability.Process(new AbilityArgs() { Damage = damage, OriginCard = originCard, TargetCard = this });
                if (PreventDamage >= damage)
                {
                    PreventDamage -= damage;
                    damage = 0;
                }
                else
                {
                    damage -= PreventDamage;
                    PreventDamage = 0;
                }
            }
            foreach (IAbility ability in originCard.Abilities.FindAll(o => o.Trigger == EffectTrigger.DamageToCreature))
                ability.Process(new AbilityArgs() { Damage = damage, OriginCard = originCard, TargetCard = this });
            DamageTaken += damage;
        }
        public void CheckTriggeredAbilities(EffectTrigger trigger)
        {
            if (trigger == EffectTrigger.None)
                return;
            throw new NotImplementedException("Card.CheckTriggeredAbilities");
        }
        public void Destroy()
        {
            CanBeDestroyed = true;
            foreach (IAbility ability in Abilities.FindAll(o => o.Trigger == EffectTrigger.CardDestroyed))
                ability.Process(new AbilityArgs() { OriginCard = this });

            if (CanBeDestroyed)
                OnCardDestroyed?.Invoke(this, new CardEventArgs() { Card = this });
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Card)) return false;  
            return Id == ((Card)obj).Id;
        }
        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
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
        public void ProcessPhasing()
        {
            PhasedOut = !PhasedOut;
            if (PhasedOut)
                OnCardPhasedOut?.Invoke(this, new CardEventArgs() { Card = this });
            else
                OnCardPhasedIn?.Invoke(this, new CardEventArgs() { Card = this });
        }
        public void Remove(Counter counter)
        {
            throw new NotImplementedException("Card.RemoveCounter");
        }
        #endregion
    }
}
