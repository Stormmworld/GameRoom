using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Effects._Base;
using System;

namespace MTG.Model.Effects
{
    public class DestroyEffect: Effect
    {
        #region Constructors
        public DestroyEffect(ITarget target) : base(GamePhase.None, Guid.NewGuid())
        {
            Assign(target);
        }
        #endregion
    }
}
