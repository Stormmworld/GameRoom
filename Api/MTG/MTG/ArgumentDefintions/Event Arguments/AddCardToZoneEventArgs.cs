using MTG.Enumerations;
using MTG.Model.Objects;
using System;

namespace MTG.ArgumentDefintions.Event_Arguments
{
    public class AddCardToZoneEventArgs: EventArgs
    {
        public Card Card { get; set; }
        public TargetZone TargetZone { get; set; }
        public Guid ZoneOwnerId { get; set; }
    }
}
