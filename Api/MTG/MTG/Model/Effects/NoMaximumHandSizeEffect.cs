using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Effects._Base;
using System;

namespace MTG.Model.Effects
{
    public class NoMaximumHandSizeEffect: Effect
    {
        #region Constructors
        public NoMaximumHandSizeEffect(ITarget target, Guid boundCardId) : base(target)
        {
            Assign(target);
        }
        #endregion
    }
}
