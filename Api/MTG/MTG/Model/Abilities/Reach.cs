using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Reach : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Reach
            702.17a Reach is a static ability.
            702.17b A creature with flying can’t be blocked except by creatures 
                    with flying and/or reach. (See rule 509, “Declare Blockers 
                    Step,” and rule 702.9, “Flying.”)
            702.17c Multiple instances of reach on the same creature are redundant.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Reach.Process");
        }
    }
}
