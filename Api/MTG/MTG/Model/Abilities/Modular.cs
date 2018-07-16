using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Modular : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Modular
            702.42a Modular represents both a static ability and a triggered ability. “Modular N” means 
                    “This permanent enters the battlefield with N +1/+1 counters on it” and “When this 
                    permanent is put into a graveyard from the battlefield, you may put a +1/+1 counter 
                    on target artifact creature for each +1/+1 counter on this permanent.”
            702.42b If a creature has multiple instances of modular, each one works separately.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
