using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Escalate : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Escalate
         702.119a Escalate is a static ability of modal spells (see rule 700.2) that functions 
                while the spell with escalate is on the stack. “Escalate [cost]” means “For each 
                mode you choose beyond the first as you cast this spell, you pay an additional 
                [cost].” Paying a spell’s escalate cost follows the rules for paying additional 
                costs in rules 601.2f–h.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Escalate.Process");
        }
    }
}
