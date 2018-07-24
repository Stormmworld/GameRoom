using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Vigilance : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Vigilance
            702.20a Vigilance is a static ability that modifies the rules for the declare attackers step.
            702.20b Attacking doesn’t cause creatures with vigilance to tap. (See rule 508, “Declare Attackers Step.”)
            702.20c Multiple instances of vigilance on the same creature are redundant.    
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Vigilance.Process");
        }
    }
}
