using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Devour : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Devour
            702.81a Devour is a static ability. “Devour N” means “As this object enters the battlefield, you 
                    may sacrifice any number of creatures. This permanent enters the battlefield with N +1/+1 
                    counters on it for each creature sacrificed this way.”
            702.81b Some objects have abilities that refer to the number of creatures the permanent devoured.
                    “It devoured” means “sacrificed as a result of its devour ability as it entered the battlefield.”
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
