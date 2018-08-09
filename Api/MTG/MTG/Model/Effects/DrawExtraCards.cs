using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;

namespace MTG.Model.Effects
{
    public class DrawExtraCards : IEffect
    {
        /*
         * DrawExtraCards
         */
        #region Properties
        public GamePhases EndingPhase { get; private set; }
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
