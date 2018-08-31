using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Effects._Base;

namespace MTG.Model.Effects
{
    public class TapEffect : Effect
    {
        #region Constructors
        public TapEffect(ITarget target) : base(target)
        {
            Assign(target);
        }
        #endregion
    }
}
