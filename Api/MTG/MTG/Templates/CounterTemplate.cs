using MTG.Interfaces;
using System;

namespace MTG.Templates
{
    public class CounterTemplate : ICounter
    {
        #region Events
        public event EventHandler OnDisposed;
        #endregion

        #region Properties
        public Guid OwningCardId { get; set; }
        public Guid ControllingPlayerId { get; set; }
        #endregion

        #region Constructors
        public CounterTemplate()
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