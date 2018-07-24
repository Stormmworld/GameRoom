using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Myriad : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Myriad
            702.115a Myriad is a triggered ability that may also create a delayed triggered 
                    ability. “Myriad” means “Whenever this creature attacks, for each opponent 
                    other than defending player, you may create a token that’s a copy of this 
                    creature that’s tapped and attacking that player or a planeswalker they 
                    control. If one or more tokens are created this way, exile the tokens at 
                    end of combat.”
            702.115b If a creature has multiple instances of myriad, each triggers separately.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Myriad.Process");
        }
    }
}
