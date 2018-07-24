using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Haunt : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Haunt
            702.54a Haunt is a triggered ability. “Haunt” on a permanent means “When this permanent is put 
                    into a graveyard from the battlefield, exile it haunting target creature.” “Haunt” on 
                    an instant or sorcery spell means “When this spell is put into a graveyard during its 
                    resolution, exile it haunting target creature.”
            702.54b Cards that are in the exile zone as the result of a haunt ability “haunt” the creature 
                    targeted by that ability. The phrase “creature it haunts” refers to the object targeted 
                    by the haunt ability, regardless of whether or not that object is still a creature.
            702.54c Triggered abilities of cards with haunt that refer to the haunted creature can trigger 
                    in the exile zone.  
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Haunt.Process");
        }
    }
}
