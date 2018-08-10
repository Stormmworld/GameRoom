using System;

namespace MTG.Interfaces
{
    public interface ICounter : IDisposable
    {
        #region Events
        event EventHandler OnDisposed;
        #endregion

        #region Properties
        Guid OwningCardId { get; set; }
        Guid ControllingPlayerId { get; set; }
        #endregion
    }
}
