using MTG.Interfaces;
using System;

namespace MTG.Model.Counters
{
    public class PlusXPlusY : ICounter
    {
        #region Events
        public event EventHandler OnDisposed;
        #endregion

        #region Properties
        public Guid OwningCardId { get; set; }
        public Guid ControllingPlayerId { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Constructors
        public PlusXPlusY()
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