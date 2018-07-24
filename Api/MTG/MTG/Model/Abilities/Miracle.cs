using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Miracle : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Miracle
            702.93a Miracle is a static ability linked to a triggered ability (see rule 603.11). “Miracle [cost]” means “You may 
                    reveal this card from your hand as you draw it if it’s the first card you’ve drawn this turn. When you reveal 
                    this card this way, you may cast it by paying [cost] rather than its mana cost.”
            702.93b If a player chooses to reveal a card using its miracle ability, they play with that card revealed until that 
                    card leaves their hand, that ability resolves, or that ability otherwise leaves the stack. 
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Miracle.Process");
        }
    }
}
