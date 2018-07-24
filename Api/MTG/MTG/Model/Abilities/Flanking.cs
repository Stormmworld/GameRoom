using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Flanking : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Flanking
            702.24a Flanking is a triggered ability that triggers during the declare blockers step. 
                    (See rule 509, “Declare Blockers Step.”) “Flanking” means “Whenever this creature
                    becomes blocked by a creature without flanking, the blocking creature gets -1/-1 
                    until end of turn.”
            702.24b If a creature has multiple instances of flanking, each triggers separately.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Flanking.Process");
        }
    }
}
