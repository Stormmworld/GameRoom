using System;

namespace MTG.Interfaces
{
    public interface IPendingAction
    {
        Guid ActionPlayerId { get; set; }
        Guid Id { get; set; }
    }
}
