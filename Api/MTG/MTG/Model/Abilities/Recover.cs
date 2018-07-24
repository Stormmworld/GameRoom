using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Recover : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Recover
             702.58a Recover is a triggered ability that functions only while the card with recover is 
                    in a player’s graveyard. “Recover [cost]” means “When a creature is put into your 
                    graveyard from the battlefield, you may pay [cost]. If you do, return this card 
                    from your graveyard to your hand. Otherwise, exile this card.”
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Recover.Process");
        }
    }
}
