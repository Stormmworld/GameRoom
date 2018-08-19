using MTG.Enumerations;
using MTG.Model.Objects;
using System;

namespace MTG.Interfaces
{
    public interface IEffect
    {
        Target Target { get; }
        GamePhases EndingPhase { get; }
        Guid EndingPhaseOwnerId { get; }
    }
}
