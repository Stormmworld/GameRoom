﻿using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;

namespace MTG.Model.Effects
{
    public class Mulligan : IEffect
    {
        /*
         * Mulligan
         *      Target player combines all cards into the library and shuffles then draws a new hand
         */
        #region Properties
        public GamePhases EndingPhase { get; private set; }
        public Target Target { get; private set; }
        public int Value { get; private set; }
        #endregion

        #region Constructors
        public Mulligan(Target target)
        {
            Target = target;
        }
        #endregion
    }
}