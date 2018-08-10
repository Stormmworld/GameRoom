﻿using System;

namespace MTG.Interfaces
{
    public interface IAbility
    {
        #region Events
        event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Properties
        Guid Id { get; }
        #endregion

        #region Methods
        string ToString();
        #endregion
    }
}
