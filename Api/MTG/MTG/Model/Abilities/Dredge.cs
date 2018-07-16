using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Dredge : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Dredge
            702.51a Dredge is a static ability that functions only while the card with dredge is in a player’s graveyard. 
                    “Dredge N” means “As long as you have at least N cards in your library, if you would draw a card, 
                    you may instead put N cards from the top of your library into your graveyard and return this card 
                    from your graveyard to your hand.”
            702.51b A player with fewer cards in their library than the number required by a dredge ability can’t put 
                    any of them into their graveyard this way.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
