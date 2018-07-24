using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Menace : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Menace
            702.110a Menace is an evasion ability.
            702.110b A creature with menace can’t be blocked except by two or more 
                    creatures. (See rule 509, “Declare Blockers Step.”)
            702.110c Multiple instances of menace on the same creature are redundant.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Menace.Process");
        }
    }
}
