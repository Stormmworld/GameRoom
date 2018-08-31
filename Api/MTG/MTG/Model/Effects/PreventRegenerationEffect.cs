using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Effects._Base;

namespace MTG.Model.Effects
{
    public class PreventRegenerationEffect : Effect
    {
        #region Constructors
        public PreventRegenerationEffect(ITarget target) : base(target)
        {
            Assign(target);
        }
        #endregion
    }
}
