using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Horsemanship : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Horsemanship
            702.30a Horsemanship is an evasion ability.
            702.30b A creature with horsemanship can’t be blocked by creatures without horsemanship. 
                    A creature with horsemanship can block a creature with or without horsemanship. 
                    (See rule 509, “Declare Blockers Step.”)
            702.30c Multiple instances of horsemanship on the same creature are redundant.    
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Horsemanship.Process");
        }
    }
}
