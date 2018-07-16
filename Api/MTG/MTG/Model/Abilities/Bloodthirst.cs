using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Bloodthirst : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Bloodthirst
            02.53a Bloodthirst is a static ability. “Bloodthirst N” means “If an opponent was dealt damage this turn, 
                    this permanent enters the battlefield with N +1/+1 counters on it.”
            702.53b “Bloodthirst X” is a special form of bloodthirst. “Bloodthirst X” means “This permanent enters 
                    the battlefield with X +1/+1 counters on it, where X is the total damage 
                    your opponents have been dealt this turn.”
            702.53c If an object has multiple instances of bloodthirst, each applies separately.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
