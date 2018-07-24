using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Infect : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Infect
            702.89a Infect is a static ability.
            702.89b Damage dealt to a player by a source with infect doesn’t cause that player to lose life. Rather, 
                    it causes that source’s controller to give the player that many poison counters. See rule 119.3.
            702.89c Damage dealt to a creature by a source with infect isn’t marked on that creature. Rather, it 
                    causes that source’s controller to put that many -1/-1 counters on that creature. See rule 119.3.
            702.89d If a permanent leaves the battlefield before an effect causes it to deal damage, its last known 
                    information is used to determine whether it had infect.
            702.89e The infect rules function no matter what zone an object with infect deals damage from.
            702.89f Multiple instances of infect on the same object are redundant.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Infect.Process");
        }
    }
}
