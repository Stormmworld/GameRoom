using System;

namespace MTG.Interfaces.Data_Interfaces
{
    public interface ICounter
    {
        #region Properties
        Guid Id { get; }
        Guid OwningCardId { get; }
        Guid ControllingPlayerId { get; }
        bool RemoveAtEndOfTurn { get; set; }
        #endregion

        #region Events
        void Assign(Guid owningCardId, Guid controllingPlayerId);
        #endregion
    }
}
