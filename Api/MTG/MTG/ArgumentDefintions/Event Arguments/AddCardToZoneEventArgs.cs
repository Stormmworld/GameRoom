using MTG.Enumerations;
using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;

namespace MTG.ArgumentDefintions.Event_Arguments
{
    public class AddCardToZoneEventArgs: EventArgs
    {
        public Card Card { get; set; }
        public TargetZone TargetZone { get; set; }
        public Guid ZoneOwnerId { get; set; }
        public List<ICastingAbility> SelectedCastingAbilities;
    }
}
