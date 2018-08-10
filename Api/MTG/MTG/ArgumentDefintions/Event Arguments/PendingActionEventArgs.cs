using MTG.Interfaces;
using System;

namespace MTG.ArgumentDefintions.Event_Arguments
{
    public class PendingActionEventArgs: EventArgs
    {
        public IPendingAction PendingAction { get; set; }
    }
}
