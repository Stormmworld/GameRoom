using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Prowl : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Prowl
            702.75a Prowl is a static ability that functions on the stack. “Prowl [cost]” means “You may 
                    pay [cost] rather than pay this spell’s mana cost if a player was dealt combat damage 
                    this turn by a source that, at the time it dealt that damage, was under your control 
                    and had any of this spell’s creature types.” Paying a spell’s prowl cost follows the 
                    rules for paying alternative costs in rules 601.2b and 601.2f–h.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Prowl.Process");
        }
    }
}
