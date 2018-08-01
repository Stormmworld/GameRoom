using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model;
using System;

namespace MTG.ArgumentDefintions.Trigger_Arguments
{
    public class PhaseTriggerArgs : ITriggerArgs
    {
        #region Properties
        public Player ActivePlayer { get; set; }
        #endregion
    }
}
