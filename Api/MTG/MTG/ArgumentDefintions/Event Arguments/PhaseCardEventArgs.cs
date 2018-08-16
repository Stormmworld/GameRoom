using System;
using MTG.Interfaces;

namespace MTG.ArgumentDefintions.Event_Arguments
{
    public class PhaseCardEventArgs : EventArgs,  ICardEventArgs
    {
        #region Properties
        public Guid CardId { get; set; }
        public Guid ControllerId { get; set; }
        public bool PhaseIn { get; set; }
        #endregion
    }
}
