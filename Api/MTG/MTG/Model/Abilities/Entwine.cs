using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Entwine : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Entwine
            702.41a Entwine is a static ability of modal spells (see rule 700.2) that functions while the spell 
                    is on the stack. “Entwine [cost]” means “You may choose all modes of this spell instead of 
                    just one. If you do, you pay an additional [cost].” Using the entwine ability follows the
                    rules for choosing modes and paying additional costs in rules 601.2b and 601.2f–h.
            702.41b If the entwine cost was paid, follow the text of each of the modes in the order written on 
                    the card when the spell resolves.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Entwine.Process");
        }
    }
}
