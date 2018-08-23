using MTG.Enumerations;
using MTG.Model.Objects;
using System;

namespace MTG.Interfaces
{
    public interface IEffect
    {
        Guid BoundCardId { get;  }
        GamePhases EndingPhase { get; }
        Guid EndingPhaseOwnerId { get; }
        Target Target { get; }
    }
}
