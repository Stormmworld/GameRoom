using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Defender : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Defender
            702.3a Defender is a static ability.
            702.3b A creature with defender can’t attack.
            702.3c Multiple instances of defender on the same creature are redundant.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Defender.Process");
        }
    }
}
