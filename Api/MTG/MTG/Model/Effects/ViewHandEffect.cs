using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Effects._Base;

namespace MTG.Model.Effects
{
    public class ViewHandEffect : Effect
    {
        #region Constructors
        public ViewHandEffect(ITarget target) : base(target)
        {
            Assign(target);
        }
        #endregion
    }
}
