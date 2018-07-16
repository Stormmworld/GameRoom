using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Improvise : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Improvise
        702.125a Improvise is a static ability that functions while the spell with improvise 
                is on the stack. “Improvise” means “For each generic mana in this spell’s total 
                cost, you may tap an untapped artifact you control rather than pay that mana.”
        702.125b The improvise ability isn’t an additional or alternative cost and applies only 
                after the total cost of the spell with improvise is determined.
        702.125c Multiple instances of improvise on the same spell are redundant.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
