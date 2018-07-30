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
        public event EventHandler CardPhasedIn, CardPhasedOut, CardTapped, CardUntapped, CardDestroyed, PendingActionTriggered;
        #endregion

        #region Variables
        private bool _PhasedOut, _Tapped;
        private List<Counter> _Counters;
        #endregion

        #region Properties
        public List<IAbility> Abilities { get; set; }
        public List<int> BandedWithCardIds { get; set; }
        public List<CardType> CardTypes { get; private set; }
        public List<Colors> Colors { get; set; }
        public int ControllerId { get; set; }
        public IReadOnlyList<Counter> Counters { get { return _Counters.AsReadOnly(); } }
        public int DamageTaken { get; set; }
        public int FaceUpSide { get; set; }
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public bool IsFaceDown { get; set; }
        public bool IsTwoSided { get; set; }
        public int OwnerId { get; set; }
        public bool PhasedOut
        {
            get { return _PhasedOut; }
            set
            {
                _PhasedOut = value;
                if (_PhasedOut)
                    CardPhasedOut?.Invoke(null, new CardEventArgs() { Card = this });
                else
                    CardPhasedIn?.Invoke(null, new CardEventArgs() { Card = this });
            }
        }
        public int Power { get; set; }
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
                    CardTapped?.Invoke(null, new CardEventArgs() { Card = this });
                else
                    CardUntapped?.Invoke(null, new CardEventArgs() { Card = this });
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

        #region Methods
        public void AddCounter(Counter counter)
        {
            throw new NotImplementedException("Card.AddCounter");
        }
        public void AddDamage(ActiveGame game, int damage, Card originCard)
        {
            if (game.Modifiers.Contains(GameModifier.CreaturesTakeNoDamage))
                return;
            foreach (IAbility ability in Abilities.FindAll(o=>o is Protection))
            {
                if (((Protection)ability).Colors.Intersect(originCard.Colors).Count() > 0)
                    return;//no damage from a color when we have protection
                if (((Protection)ability).CardTypes.Intersect(originCard.CardTypes).Count() > 0)
                    return;//no damage from a card sub type when we have protection
                if (((Protection)ability).SubTypes.Intersect(originCard.SubTypes).Count() > 0)
                    return;//no damage from a card type when we have protection
            }
            if (originCard.Abilities.FirstOrDefault(o => o is Deathtouch) != null)
                SufferingFromDeathtouchEffect = damage > 0;

            if (damage > 0)
                throw new NotImplementedException("Card.AddDamage - Trigger effects on damages a creature");

            DamageTaken = DamageTaken + damage;
        }
        public bool AttackerDealsDamage()
        {
            bool hasVigilance = Abilities.FirstOrDefault(p => p is Vigilance) != null;
            return Tapped || hasVigilance;
        }
        public void DealtDamage(ActiveGame game, TargetType damagedEntity)
        {
            //Lifelink
            //triggered effects get pending actions
            throw new NotImplementedException("Card.DealtDamage");
        }
        public void Destroy()
        {
            if (Abilities.FirstOrDefault(o => o is Indestructible) == null)
                CardDestroyed?.Invoke(this, new CardEventArgs() { Card = this });
        }
        public void FlipCard()
        {
            FaceUpSide = (FaceUpSide == 1) ? 2 : 1;
        }
        public Card GetFacedownCardDetails()
        {
            Morph morphAbility = (Morph)Abilities.First(o=>o is Morph);
            Card faceDownCard = morphAbility.FaceDownCard();
            faceDownCard.Id = this.Id;
            return faceDownCard;
        }
        public bool HasFirstStrike()
        {
            return Abilities.FirstOrDefault(p => p is First_Strike)!= null;
        }
        public bool HasDoubleStrike()
        {
            return Abilities.FirstOrDefault(p => p is Double_Strike) != null;
        }
        public bool HasNormalStrike()
        {
            return Abilities.FirstOrDefault(p => p is First_Strike) == null;
        }
        public void Morph()
        {
            IsFaceDown = false;
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
                CardPhasedOut?.Invoke(this, new CardEventArgs() { Card = this });
            else
                CardPhasedIn?.Invoke(this, new CardEventArgs() { Card = this });
        }
        public void RemoveCounter(Counter counter)
        {
            throw new NotImplementedException("Card.RemoveCounter");
        }
        #endregion
    }
}
