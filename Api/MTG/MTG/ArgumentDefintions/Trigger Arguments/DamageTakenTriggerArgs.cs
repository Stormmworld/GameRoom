using MTG.Interfaces;
using MTG.Model;

namespace MTG.ArgumentDefintions.Trigger_Arguments
{
    public class DamageTakenTriggerArgs : ITriggerArgs
    {
        #region Properties
        public Player ActivePlayer { get; set; }
        public int Damage { get; set; }
        #endregion
    }
}
