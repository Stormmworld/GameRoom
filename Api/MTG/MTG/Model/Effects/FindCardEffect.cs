using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Effects._Base;

namespace MTG.Model.Effects
{
    public class FindCardEffect : Effect
    {
        #region Constructors
        public FindCardEffect(ITarget target) : base(target)
        {
            Assign(target);
        }
        #endregion
    }
}
