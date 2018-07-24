using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Echo : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Echo
            702.29a Echo is a triggered ability. “Echo [cost]” means “At the beginning of your upkeep, 
                    if this permanent came under your control since the beginning of your last upkeep, 
                    sacrifice it unless you pay [cost].”
            702.29b Urza block cards with the echo ability were printed without an echo cost. 
                    These cards have been given errata in the Oracle card reference; each one now has 
                    an echo cost equal to its mana cost.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Echo.Process");
        }
    }
}
