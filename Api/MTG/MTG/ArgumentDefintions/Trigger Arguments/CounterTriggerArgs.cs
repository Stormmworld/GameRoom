using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model;
using MTG.Model.Objects;

namespace MTG.ArgumentDefintions.Trigger_Arguments
{
    public class CounterTriggerArgs : ITriggerArgs
    {
        #region Properties
        public Player ActivePlayer { get; set; }
        public Card ActiveCard { get; set; }
        public ICounter Counter { get; set; }
        #endregion
    }
}
