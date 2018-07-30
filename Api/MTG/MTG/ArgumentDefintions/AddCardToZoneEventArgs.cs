using MTG.Enumerations;
using MTG.Model;
using MTGModel.Objects;
using System;

namespace MTG.ArgumentDefintions
{
    public class AddCardToZoneEventArgs: EventArgs
    {
        public Card Card { get; set; }
        public TargetZone TargetZone { get; set; }
        public Player ZoneOwner { get; set; }
    }
}
