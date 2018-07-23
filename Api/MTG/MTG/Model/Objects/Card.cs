using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Interfaces;
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
        public event EventHandler CardPhasedIn, CardPhasedOut, CardTapped, CardUntapped, CardDestroyed;
        #endregion

        #region Variables
        private bool _PhasedOut, _Tapped;
        private List<Counter> _Counters;
        #endregion

        #region Properties
        public List<IAbility> Abilities { get; set; }
        public List<CardType> CardTypes { get; private set; }
        public List<Colors> Colors { get; set; }
        public IReadOnlyList<Counter> Counters { get { return _Counters.AsReadOnly(); } }
        public int DamageTaken { get; set; }
        public int FaceUpSide { get; set; }
        public int Id { get; set; }
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
        public bool UntapDuringUntapPhase { get; set; }
        public UpkeepTriggers UpkeepTrigger { get; set; }
        public UpkeepRequirement UpkeepRequirement { get; set; }
        #endregion

        #region Constructors
        public Card()
        {
            Abilities = new List<IAbility>();
            CardTypes = new List<CardType>();
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
        }
        #endregion

        #region Methods
        public void AddCounter(Counter counter)
        {
            throw new NotImplementedException("Card.AddCounter");
        }
        public void AddDamage(int damage, List<Colors> colors, List<CardType> cardTypes, List<SubType> subTypes)
        {
            foreach (IAbility ability in Abilities.FindAll(o=>o is Protection))
            {
                if (((Protection)ability).Colors.Intersect(colors).Count() > 0)
                    return;//no damage from a color when we have protection
                if (((Protection)ability).CardTypes.Intersect(cardTypes).Count() > 0)
                    return;//no damage from a card sub type when we have protection
                if (((Protection)ability).SubTypes.Intersect(subTypes).Count() > 0)
                    return;//no damage from a card type when we have protection
            }
            DamageTaken = DamageTaken + damage;
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
        public void Morph()
        {
            IsFaceDown = false;
        }
        public void ProcessDamage()
        {
            if (DamageTaken >= Toughness)
                Destroy();
        }
        public void RemoveCounter(Counter counter)
        {
            throw new NotImplementedException("Card.RemoveCounter");
        }
        #endregion
    }
}
