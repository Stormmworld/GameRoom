using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Hexproof : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Hexproof
            702.11a Hexproof is a static ability.
            702.11b “Hexproof” on a permanent means “This permanent can’t be the target 
                    of spells or abilities your opponents control.”
            702.11c “Hexproof” on a player means “You can’t be the target of spells or 
                    abilities your opponents control.”
            702.11d “Hexproof from [quality]” is a variant of the hexproof ability. 
                    “Hexproof from [quality]” on a permanent means “This permanent can’t 
                    be the target of [quality] spells your opponents control or abilities 
                    your opponents control from [quality] sources.” A “hexproof from 
                    [quality]” ability is a hexproof ability.
            702.11e Any effect that causes an object to lose hexproof will cause an 
                    object to lose all “hexproof from [quality]” abilities. Any 
                    effect that allows a player to choose a creature with hexproof as a 
                    target as though it didn’t have hexproof will allow a player to 
                    choose a creature with a “hexproof from [quality]” ability. Any 
                    effect that looks for a card with hexproof will find a card with a 
                    “hexproof from [quality]” ability.
            702.11f Multiple instances of the same hexproof ability on the same 
                    permanent or player are redundant.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
