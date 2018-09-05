using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Effects._Base;

namespace MTG.Model.Effects
{
    public class DiscardEffect : Effect
    {
        #region Constructors
        public DiscardEffect(ITarget target) : base(target)
        {
            Assign(target);
        }
        #endregion
    }
}
