using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Flying : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Flying
            702.9a Flying is an evasion ability.
            702.9b A creature with flying can’t be blocked except by creatures with flying and/or reach. A creature 
                    with flying can block a creature with or without flying. (See rule 509, “Declare Blockers Step,” 
                    and rule 702.17, “Reach.”)
            702.9c Multiple instances of flying on the same creature are redundant.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
