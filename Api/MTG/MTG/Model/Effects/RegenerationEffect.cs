using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Effects._Base;

namespace MTG.Model.Effects
{
    public class RegenerationEffect:Effect
    {
        #region Constructors
        public RegenerationEffect(ITarget target) : base(target)
        {
            Assign(target);
        }
        #endregion
    }
}
