using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Fear : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Fear
            702.35a Fear is an evasion ability.
            702.35b A creature with fear can’t be blocked except by artifact creatures 
                    and/or black creatures. (See rule 509, “Declare Blockers Step.”)
            702.35c Multiple instances of fear on the same creature are redundant.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Fear.Process");
        }
    }
}
