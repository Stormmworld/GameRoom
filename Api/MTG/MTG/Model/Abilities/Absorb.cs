using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Absorb : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Absorb
            702.63a Absorb is a static ability. “Absorb N” means “If a source would deal 
                    damage to this creature, prevent N of that damage.”
            702.63b Each absorb ability can prevent only N damage from any one source at 
                    any one time. It will apply separately to damage from other sources, 
                    or to damage dealt by the same source at a different time.
            702.63c If an object has multiple instances of absorb, each applies separately.
         */

        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Absorb.Process");
        }
    }
}
