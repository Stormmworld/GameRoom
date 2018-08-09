using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;

namespace MTG.Model.Effects
{
    public class AdditionalTurn : IEffect
    {
        /*
         * AdditionalTurn
         */
        #region Properties
        public GamePhases EndingPhase { get; private set; }
        public Target Target { get; private set; }
        public int Value { get; private set; }
        #endregion

        #region Constructors
        public AdditionalTurn()
        {
        }
        #endregion
    }
}
