using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Rampage : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Rampage
            702.22a Rampage is a triggered ability. “Rampage N” means “Whenever this creature becomes 
                    blocked, it gets +N/+N until end of turn for each creature blocking it beyond the 
                    first.” (See rule 509, “Declare Blockers Step.”)
            702.22b The rampage bonus is calculated only once per combat, when the triggered ability 
                    resolves. Adding or removing blockers later in combat won’t change the bonus.
            702.22c If a creature has multiple instances of rampage, each triggers separately.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
