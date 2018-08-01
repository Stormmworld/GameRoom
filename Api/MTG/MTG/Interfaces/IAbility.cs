using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System;
using System.Collections.Generic;

namespace MTG.Interfaces
{
    public interface IAbility
    {
        #region Events
        event EventHandler PendingActionTriggered, EffectTriggered;
        #endregion

        #region Properties
        IReadOnlyCollection<AbilityType> Types { get; }
        EffectTrigger Trigger { get;  }
        #endregion

        #region Methods
        void Process(AbilityArgs args);
        #endregion
    }
}
