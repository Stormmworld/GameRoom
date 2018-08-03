using MTG.ArgumentDefintions;
using MTG.Model.Objects;
using System;

namespace MTG.Interfaces
{
    public interface IUpkeepAbility : IAbility
    {
        IAbility FailedUpkeep { get; }
        Guid Id { get; }
        UpkeepAction Action { get; }

        void CheckResolution(AbilityArgs args);
    }
}
