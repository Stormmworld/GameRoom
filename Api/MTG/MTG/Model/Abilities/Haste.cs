using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Haste : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Haste
            702.10a Haste is a static ability.
            702.10b If a creature has haste, it can attack even if it hasn’t been controlled by its 
                    controller continuously since their most recent turn began. (See rule 302.6.)
            702.10c If a creature has haste, its controller can activate its activated abilities 
                    whose cost includes the tap symbol or the untap symbol even if that creature 
                    hasn’t been controlled by that player continuously since their most recent 
                    turn began. (See rule 302.6.)
            702.10d Multiple instances of haste on the same creature are redundant. 
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
