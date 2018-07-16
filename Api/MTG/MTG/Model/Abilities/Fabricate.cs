using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Fabricate
    {
        /*
         * https://mtg.gamepedia.com/Fabricate
            702.122a Fabricate is a triggered ability. “Fabricate N” means “When 
                    this permanent enters the battlefield, you may put N +1/+1 
                    counters on it. If you don’t, create N 1/1 colorless Servo 
                    artifact creature tokens.”
            702.122b If a permanent has multiple instances of fabricate, each 
                    triggers separately.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
