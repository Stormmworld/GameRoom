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
        private List<IAbility> _Abilities;
        private List<CardType> _CardTypes;
        private List<Colors> _Colors;
        private List<SubType> _SubTypes;
        private List<SuperType> _SuperTypes;
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
        public int ControllerId { get; set; }
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
        public int Toughness { get; set; }
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
            throw new NotImplementedException("Card.Constructor");
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
            throw new NotImplementedException("Card.AddCounter");
        }
        public void AddDamage(ActiveGame game, int damage, Card originCard)
        {
            if (game.Modifiers.Contains(GameModifier.CreaturesTakeNoDamage))
                return; 
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
        public void Remove(Counter counter)
        {
            throw new NotImplementedException("Card.RemoveCounter");
        }
        #endregion
    }
}
