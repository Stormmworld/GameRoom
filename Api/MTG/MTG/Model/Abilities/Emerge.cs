using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Emerge : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Emerge
            702.118a Emerge represents two static abilities that function while the spell with emerge 
                    is on the stack. “Emerge [cost]” means “You may cast this spell by paying [cost] 
                    and sacrificing a creature rather than paying its mana cost” and “If you chose to 
                    pay this spell’s emerge cost, its total cost is reduced by an amount of generic 
                    mana equal to the sacrificed creature’s converted mana cost.” Paying a card’s 
                    emerge cost follows the rules for paying alternative costs in rules 601.2b and 
                    601.2f–h.
            702.118b You choose which creature to sacrifice as you choose to pay a spell’s emerge 
                    cost (see rule 601.2b), and you sacrifice that creature as you pay the total 
                    cost (see rule 601.2h).
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
