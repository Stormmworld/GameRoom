using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Convoke : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Convoke
            702.50a Convoke is a static ability that functions while the spell with convoke is on the stack. “Convoke” means 
                    “For each colored mana in this spell’s total cost, you may tap an untapped creature of that color you 
                    control rather than pay that mana. For each generic mana in this spell’s total cost, you may tap an 
                    untapped creature you control rather than pay that mana.”
            702.50b The convoke ability isn’t an additional or alternative cost and applies only after the total cost of 
                    the spell with convoke is determined.
                Example: Heartless Summoning says, in part, “Creature spells you cast cost {2} less to cast.” You control 
                        Heartless Summoning and cast Siege Wurm, a spell with convoke that costs {5}{G}{G}. The total cost 
                        to cast Siege Wurm is {3}{G}{G}. After activating mana abilities, you pay that total cost. You may 
                        tap up to two green creatures and up to three other creatures to pay that cost, and the remainder 
                        is paid with mana.
            702.50c Multiple instances of convoke on the same spell are redundant.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
