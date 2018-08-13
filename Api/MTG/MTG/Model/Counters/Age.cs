using MTG.Interfaces;
using System;

namespace MTG.Model.Counters
{
    public class Age : ICounter
    {
        #region Events
        public event EventHandler OnDisposed;
        #endregion

        #region Properties
        public Guid OwningCardId { get; set; }
        public Guid ControllingPlayerId { get; set; }
        #endregion

        #region Constructors
        public Age()
        {
        }
        #endregion

        #region Methods
        public void Dispose()
        {
            OnDisposed?.Invoke(this, new EventArgs());
        }
        #endregion

    }
}