using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;
using System;

namespace MTG.ArgumentDefintions.Event_Arguments
{
    public class MoveToZoneCardEventArgs:EventArgs, ICardEventArgs
    {
        #region Properties
        public Guid CardId { get; set; }
        public Guid ControllerId { get; set; }
        public Card Card { get; set; }
        public TargetZone TargetZone { get; set; }
        public Guid ZoneOwnerId { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}
