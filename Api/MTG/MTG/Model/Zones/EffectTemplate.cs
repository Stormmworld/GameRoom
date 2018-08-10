using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Zones
{
    public class EffectTemplate : IEffect
    {
        /*
         * EffectTemplate
         */
        #region Properties
        public GamePhases EndingPhase { get; private set; }
        public Guid EndingPhaseOwnerId { get; set; }
        public Target Target { get; private set; }
        public int Value { get; private set; }
        #endregion

        #region Constructors
        public EffectTemplate()
        {
            EndingPhaseOwnerId  = new Guid();
            Target = new Target();
        }
        #endregion
    }
}
