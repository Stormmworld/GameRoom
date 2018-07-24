using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Graft : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Graft
            702.57a Graft represents both a static ability and a triggered ability. “Graft N” means 
                    “This permanent enters the battlefield with N +1/+1 counters on it” and “Whenever 
                    another creature enters the battlefield, if this permanent has a +1/+1 counter on 
                    it, you may move a +1/+1 counter from this permanent onto that creature.”
            702.57b If a permanent has multiple instances of graft, each one works separately.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Graft.Process");
        }
    }
}
