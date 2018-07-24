using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Landwalk : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Landwalk
            702.14a Landwalk is a generic term that appears within an object’s rules text as “[type]walk,” 
                    where [type] is usually a subtype, but can be the card type land, any land type, any 
                    supertype, or any combination thereof.
            702.14b Landwalk is an evasion ability.
            702.14c A creature with landwalk can’t be blocked as long as the defending player controls at 
                    least one land with the specified subtype (as in “islandwalk”), with the specified 
                    supertype (as in “legendary landwalk”), without the specified supertype (as in “nonbasic 
                    landwalk”), or with both the specified supertype and the specified subtype (as in “snow 
                    swampwalk”). (See rule 509, “Declare Blockers Step.”)
            702.14d Landwalk abilities don’t “cancel” one another.
                Example: If a player controls a snow Forest, that player can’t block an attacking creature 
                        with snow forestwalk even if they also control a creature with snow forestwalk.
            702.14e Multiple instances of the same kind of landwalk on the same creature are redundant.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Landwalk.Process");
        }
    }
}
