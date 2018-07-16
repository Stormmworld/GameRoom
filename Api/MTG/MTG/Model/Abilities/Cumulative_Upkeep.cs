﻿using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Cumulative_Upkeep : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Cumulative_upkeep
            702.23a Cumulative upkeep is a triggered ability that imposes an increasing cost on a permanent.
                    “Cumulative upkeep [cost]” means “At the beginning of your upkeep, if this permanent 
                    is on the battlefield, put an age counter on this permanent. Then you may pay [cost] 
                    for each age counter on it. If you don’t, sacrifice it.” If [cost] has choices associated 
                    with it, each choice is made separately for each age counter, then either the entire 
                    set of costs is paid, or none of them is paid. Partial payments aren’t allowed.
                Example: A creature has “Cumulative upkeep {W} or {U}” and two age counters on it. When its 
                        ability next triggers and resolves, the creature’s controller puts an age counter on 
                        it and then may pay {W}{W}{W}, {W}{W}{U}, {W}{U}{U}, or {U}{U}{U} to keep the creature 
                        on the battlefield.
                Example: A creature has “Cumulative upkeep—Sacrifice a creature” and one age counter on it. 
                        When its ability next triggers and resolves, its controller can’t choose the same 
                        creature to sacrifice twice. Either two different creatures must be sacrificed, 
                        or the creature with cumulative upkeep must be sacrificed.
            702.23b If a permanent has multiple instances of cumulative upkeep, each triggers separately. 
                    However, the age counters are not connected to any particular ability; each cumulative 
                    upkeep ability will count the total number of age counters on the permanent at the 
                    time that ability resolves.
                Example: A creature has two instances of “Cumulative upkeep—Pay 1 life.” The creature has 
                        no age counters, and both cumulative upkeep abilities trigger. When the first ability 
                        resolves, the controller adds a counter and then chooses to pay 1 life. When the second 
                        ability resolves, the controller adds another counter and then chooses to pay an 
                        additional 2 life.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
