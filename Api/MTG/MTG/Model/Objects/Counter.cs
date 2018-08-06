using MTG.Enumerations;
using System;

namespace MTG.Model.Objects
{
    public class Counter: IDisposable
    {
        #region Events
        public event EventHandler OnDisposed;
        #endregion

        #region Variables
        #endregion

        #region Properties
        public CounterType CounterType { get; set; }
        public int OwningCardId { get; set; }
        public int OwningPlayerId { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Methods
        public void Dispose()
        {
            OnDisposed?.Invoke(this, new EventArgs());
        }
        #endregion

    }
}
