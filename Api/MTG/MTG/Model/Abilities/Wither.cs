using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Wither : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Wither
            702.79a Wither is a static ability. Damage dealt to a creature by a source with wither isn’t 
                    marked on that creature. Rather, it causes that source’s controller to put that many 
                    -1/-1 counters on that creature. See rule 119.3.
            702.79b If a permanent leaves the battlefield before an effect causes it to deal damage, its 
                    last known information is used to determine whether it had wither.
            702.79c The wither rules function no matter what zone an object with wither deals damage from.
            702.79d Multiple instances of wither on the same object are redundant.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Wither.Process");
        }
    }
}
