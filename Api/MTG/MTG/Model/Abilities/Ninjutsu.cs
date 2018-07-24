using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Ninjutsu : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Ninjutsu
            702.48a Ninjutsu is an activated ability that functions only while the card with 
                    ninjutsu is in a player’s hand. “Ninjutsu [cost]” means “[Cost], Reveal 
                    this card from your hand, Return an unblocked attacking creature you 
                    control to its owner’s hand: Put this card onto the battlefield from your 
                    hand tapped and attacking.”
            702.48b The card with ninjutsu remains revealed from the time the ability is 
                    announced until the ability leaves the stack.
            702.48c A ninjutsu ability may be activated only while a creature on the 
                    battlefield is unblocked (see rule 509.1h). The creature with ninjutsu 
                    is put onto the battlefield unblocked. It will be attacking the same 
                    player or planeswalker as the creature that was returned to its owner’s 
                    hand. 
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Ninjutsu.Process");
        }
    }
}
