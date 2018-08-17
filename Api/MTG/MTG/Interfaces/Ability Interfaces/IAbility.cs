using System;

namespace MTG.Interfaces.Ability_Interfaces
{
    public interface IAbility
    {
        #region Events
        event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        Guid Id { get; }
        #endregion

        #region Methods
        string ToString();
        #endregion
    }
}
