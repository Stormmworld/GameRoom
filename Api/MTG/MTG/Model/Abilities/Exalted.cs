using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Exalted : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Exalted
            702.82a Exalted is a triggered ability. “Exalted” means “Whenever a creature you control attacks alone, that creature gets +1/+1 until end of turn.”
            702.82b A creature “attacks alone” if it’s the only creature declared as an attacker in a given combat phase. See rule 506.5.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Exalted.Process");
        }
    }
}
