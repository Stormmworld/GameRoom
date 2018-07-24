using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Evoke : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Evoke
            702.73a Evoke represents two abilities: a static ability that functions in any zone 
                    from which the card with evoke can be cast and a triggered ability that functions 
                    on the battlefield. “Evoke [cost]” means “You may cast this card by paying [cost] 
                    rather than paying its mana cost” and “When this permanent enters the battlefield, 
                    if its evoke cost was paid, its controller sacrifices it.” Paying a card’s evoke 
                    cost follows the rules for paying alternative costs in rules 601.2b and 601.2f–h.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Evoke.Process");
        }
    }
}
