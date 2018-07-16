using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Intimidate : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Intimidate
            702.13a Intimidate is an evasion ability.
            702.13b A creature with intimidate can’t be blocked except by artifact creatures and/or 
                    creatures that share a color with it. (See rule 509, “Declare Blockers Step.”)
            702.13c Multiple instances of intimidate on the same creature are redundant.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
