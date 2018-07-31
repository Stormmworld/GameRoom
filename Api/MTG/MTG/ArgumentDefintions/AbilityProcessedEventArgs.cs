using MTG.Interfaces;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;

namespace MTG.ArgumentDefintions
{
    public class AbilityProcessedEventArgs : EventArgs
    {
        #region Properties
        public List<Effect> Effects { get; set; }
        public List<IPendingAction> PendingActions { get; set; }
        #endregion
    }
}
