using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Skulk : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Skulk
            702.117a Skulk is an evasion ability.
            702.117b A creature with skulk can’t be blocked by creatures with greater 
                    power. (See rule 509, “Declare Blockers Step.”)
            702.117c Multiple instances of skulk on the same creature are redundant.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Skulk.Process");
        }
    }
}
