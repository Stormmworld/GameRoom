using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Effects._Base;

namespace MTG.Model.Effects
{
    public class UntapEffect : Effect
    {
        #region Constructors
        public UntapEffect(ITarget target) : base(target)
        {
            Assign(target);
        }
        #endregion
    }
}
