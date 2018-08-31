using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Effects._Base;
using System;

namespace MTG.Model.Effects
{
    public class RegenerationEffect:Effect
    {
        #region Constructors
        public RegenerationEffect(ITarget target) : base(GamePhase.None, Guid.NewGuid())
        {
            Assign(target);
        }
        #endregion
    }
}
