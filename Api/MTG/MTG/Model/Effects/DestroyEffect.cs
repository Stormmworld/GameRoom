using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Effects._Base;

namespace MTG.Model.Effects
{
    public class DestroyEffect: Effect
    {
        #region Constructors
        public DestroyEffect(ITarget target) : base(target)
        {
            Assign(target);
        }
        #endregion
    }
}
