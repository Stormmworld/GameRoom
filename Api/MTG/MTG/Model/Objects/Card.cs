using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;

namespace MTGModel.Objects
{
    public class Card
    {
        #region Events
        public event EventHandler CardPhasedIn, CardPhasedOut, CardTapped, CardUntapped;
        #endregion

        #region Variables
        private bool _PhasedOut, _Tapped;
        #endregion

        #region Properties
        public List<IAbility> Abilities { get; set; } 
        public List<CardType> CardTypes { get; set; }
        public string OwnerId { get; set; }
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
        public bool SelectedToUntap { get; set; }
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
        #endregion
    }
}
