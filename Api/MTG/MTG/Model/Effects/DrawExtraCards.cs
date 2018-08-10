using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Effects
{
    public class DrawExtraCards : IEffect
    {
        /*
         * DrawExtraCards
         */
        #region Properties
        public GamePhases EndingPhase { get; private set; }
        public Guid EndingPhaseOwnerId { get; set; }
        public Target Target { get; private set; }
        public int Value { get; private set; }
        #endregion

        #region Constructors
        public DrawExtraCards()
        {
        }
        #endregion
    }
}
