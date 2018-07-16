using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Dash : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Dash
            702.108a Dash represents three abilities: two static abilities that function while 
                    the card with dash is on the stack, one of which may create a delayed triggered 
                    ability, and a static ability that functions while the object with dash is on 
                    the battlefield. “Dash [cost]” means “You may cast this card by paying [cost] 
                    rather than its mana cost,” “If this spell’s dash cost was paid, return the 
                    permanent this spell becomes to its owner’s hand at the beginning of the next 
                    end step,” and “As long as this permanent’s dash cost was paid, it has haste.” 
                    Paying a card’s dash cost follows the rules for paying alternative costs in 
                    rules 601.2b and 601.2f–h.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
