using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Shadow : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Shadow
            702.27a Shadow is an evasion ability.
            702.27b A creature with shadow can’t be blocked by creatures without shadow, and a 
                    creature without shadow can’t be blocked by creatures with shadow. (See 
                    rule 509, “Declare Blockers Step.”)
            702.27c Multiple instances of shadow on the same creature are redundant.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Shadow.Process");
        }
    }
}
