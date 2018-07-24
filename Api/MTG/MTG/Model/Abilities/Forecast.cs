using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Forecast : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Forecast
            702.56a A forecast ability is a special kind of activated ability that can be activated only 
                    from a player’s hand. It’s written “Forecast — [Activated ability].”
            702.56b A forecast ability may be activated only during the upkeep step of the card’s owner 
                    and only once each turn. The controller of the forecast ability reveals the card with 
                    that ability from their hand as the ability is activated. That player plays with that 
                    card revealed in their hand until it leaves the player’s hand or until a step or phase 
                    that isn’t an upkeep step begins, whichever comes first.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Forecast.Process");
        }
    }
}
