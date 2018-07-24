using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Ripple : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Ripple
            702.59a Ripple is a triggered ability that functions only while the card with 
                    ripple is on the stack. “Ripple N” means “When you cast this spell, you 
                    may reveal the top N cards of your library, or, if there are fewer than 
                    N cards in your library, you may reveal all the cards in your library. 
                    If you reveal cards from your library this way, you may cast any of those 
                    cards with the same name as this spell without paying their mana costs, 
                    then put all revealed cards not cast this way on the bottom of your 
                    library in any order.”
            702.59b If a spell has multiple instances of ripple, each triggers separately.        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Ripple.Process");
        }
    }
}
