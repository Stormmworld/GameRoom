using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Delve : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Delve
            702.65a Delve is a static ability that functions while the spell with delve 
                    is on the stack. “Delve” means “For each generic mana in this spell’s 
                    total cost, you may exile a card from your graveyard rather than pay 
                    that mana.”
            702.65b The delve ability isn’t an additional or alternative cost and applies 
                    only after the total cost of the spell with delve is determined.
            702.65c Multiple instances of delve on the same spell are redundant.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
