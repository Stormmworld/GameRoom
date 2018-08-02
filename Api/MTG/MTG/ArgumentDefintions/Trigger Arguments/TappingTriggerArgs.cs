using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model;
using MTGModel.Objects;

namespace MTG.ArgumentDefintions.Trigger_Arguments
{
    public class TappingTriggerArgs : ITriggerArgs
    {
        #region Properties
        public Player ActivePlayer { get; set; }
        public Card ActiveCard { get; set; }
        public TappingTypes TappingType { get; set; }
        #endregion
    }
}
