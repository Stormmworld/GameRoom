using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Hideaway : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Hideaway
            702.74a Hideaway represents a static ability and a triggered ability. “Hideaway” means 
                    “This permanent enters the battlefield tapped” and “When this permanent enters 
                    the battlefield, look at the top four cards of your library. Exile one of them 
                    face down and put the rest on the bottom of your library in any order. The 
                    exiled card gains ‘Any player who has controlled the permanent that exiled this 
                    card may look at this card in the exile zone.’”   
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Hideaway.Process");
        }
    }
}
