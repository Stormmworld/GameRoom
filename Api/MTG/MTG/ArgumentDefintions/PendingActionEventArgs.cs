using MTG.Interfaces;
using System;

namespace MTG.ArgumentDefintions
{
    public class PendingActionEventArgs: EventArgs
    {
        public IPendingAction PendingAction { get; set; }
    }
}
