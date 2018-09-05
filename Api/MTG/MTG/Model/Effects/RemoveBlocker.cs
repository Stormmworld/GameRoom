using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Effects._Base;

namespace MTG.Model.Effects
{
    public class RemoveBlocker : Effect
    {
        #region Constructors
        public RemoveBlocker(ITarget target) : base(target)
        {
            Assign(target);
        }
        #endregion
    }
}
