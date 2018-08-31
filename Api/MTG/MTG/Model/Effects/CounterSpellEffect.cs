using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Effects._Base;

namespace MTG.Model.Effects
{
    public class CounterspellEffect : Effect
    {
        #region Constructors
        public CounterspellEffect(ITarget target) : base(target)
        {
            Assign(target);
        }
        #endregion
    }
}
