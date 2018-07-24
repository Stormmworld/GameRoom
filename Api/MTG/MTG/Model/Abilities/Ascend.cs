using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Ascend : IAbility
    {
            /*
             * https://mtg.gamepedia.com/Ascend
                702.130a Ascend on an instant or sorcery spell represents a spell ability. It means 
                        “If you control ten or more permanents and you don’t have the city’s blessing, 
                        you get the city’s blessing for the rest of the game.”
                702.130b Ascend on a permanent represents a static ability. It means “Any time you 
                        control ten or more permanents and you don’t have the city’s blessing, you 
                        get the city’s blessing for the rest of the game.”
                702.130c The city’s blessing is a designation that has no rules meaning other than 
                        to act as a marker that other rules and effects can identify. Any number 
                        of players may have the city’s blessing at the same time.
                702.130d After a player gets the city’s blessing, continuous effects are reapplied 
                        before the game checks to see if the game state or preceding events have 
                        matched any trigger conditions.
             */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Ascend.Process");
        }
    }
}
