using MTG.ArgumentDefintions;
using System;

namespace MTG.Interfaces
{
    public interface IUpkeepAbility : IAbility
    {
        IAbility FailedUpkeep { get; }
        Guid Id { get; }
        bool Success { get; }
        bool RequiresInteraction { get; }

        void CheckResolution(AbilityArgs args);
    }
}
