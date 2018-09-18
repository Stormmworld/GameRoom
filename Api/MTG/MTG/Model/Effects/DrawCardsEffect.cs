using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Effects._Base;

namespace MTG.Model.Effects
{
    public class DrawCardsEffect : Effect
    {
        #region Properties
        public int DrawCount { get; private set; }
        #endregion

        #region Constructors
        public DrawCardsEffect(ITarget target, int drawCount) : base(target)
        {
            Assign(target);
            DrawCount = drawCount;
        }
        #endregion
    }
}
