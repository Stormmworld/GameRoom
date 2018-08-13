using System;

namespace MTG.Interfaces
{
    public interface ICompleteActionRequest
    {
        Guid ActionId { get; }
        Guid ActionPlayerId { get; }
    }
}
