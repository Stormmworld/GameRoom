using MTG.Interfaces;
using System;

namespace MTG.ArgumentDefintions.Event_Arguments
{
    public class DeclaredAttackerCardEventArgs : EventArgs, ICardEventArgs
    {
        #region Properties
        public Guid CardId { get; set; }
        public Guid ControllerId { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}