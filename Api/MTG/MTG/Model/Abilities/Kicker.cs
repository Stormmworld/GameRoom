using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Kicker : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Kicker
            702.32a Kicker is a static ability that functions while the spell with kicker is on the stack. “Kicker [cost]” means 
                    “You may pay an additional [cost] as you cast this spell.” Paying a spell’s kicker cost(s) follows the rules 
                    for paying additional costs in rules 601.2b and 601.2f–h.
            702.32b The phrase “Kicker [cost 1] and/or [cost 2]” means the same thing as “Kicker [cost 1], kicker [cost 2].”
            702.32c Multikicker is a variant of the kicker ability. “Multikicker [cost]” means “You may pay an additional [cost] 
                    any number of times as you cast this spell.” A multikicker cost is a kicker cost.
            702.32d If a spell’s controller declares the intention to pay any of that spell’s kicker costs, that spell has been 
                    “kicked.” If a spell has two kicker costs or has multikicker, it may be kicked multiple times. See rule 601.2b.
            702.32e Objects with kicker or multikicker have additional abilities that specify what happens if they are kicked. 
                    These abilities are linked to the kicker or multikicker abilities printed on that object: they can refer only 
                    to those specific kicker or multikicker abilities. See rule 607, “Linked Abilities.”
            702.32f Objects with more than one kicker cost have abilities that each correspond to a specific kicker cost. They 
                    contain the phrases “if it was kicked with its [A] kicker” and “if it was kicked with its [B] kicker,” where A 
                    and B are the first and second kicker costs listed on the card, respectively. Each of those abilities is linked 
                    to the appropriate kicker ability.
            702.32g If part of a spell’s ability has its effect only if that spell was kicked, and that part of the ability includes
                    any targets, the spell’s controller chooses those targets only if that spell was kicked. Otherwise, the spell is 
                    cast as if it did not have those targets. See rule 601.2c.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Kicker.Process");
        }
    }
}
