using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Effects._Base;

namespace MTG.Model.Effects
{
    public class GainLifeEffect : Effect
    {
        #region Constructors
        public GainLifeEffect(ITarget target, int value) : base(target)
        {
            Assign(target);
        }
        #endregion
    }
}
