using MTG.Interfaces;
using MTG.Model;

namespace MTG.ArgumentDefintions.Trigger_Arguments
{
    public class LifeGainedTriggerArgs : ITriggerArgs
    {
        #region Properties
        public Player ActivePlayer { get; set; }
        public int LifeGained { get; set; }
        #endregion
    }
}
