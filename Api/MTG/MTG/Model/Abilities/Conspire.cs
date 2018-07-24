﻿using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Conspire : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Conspire
            702.77a Conspire is a keyword that represents two abilities. The first is a static ability that functions 
                    while the spell with conspire is on the stack. The second is a triggered ability that functions 
                    while the spell with conspire is on the stack. “Conspire” means “As an additional cost to cast 
                    this spell, you may tap two untapped creatures you control that each share a color with it” and 
                    “When you cast this spell, if its conspire cost was paid, copy it. If the spell has any targets, 
                    you may choose new targets for the copy.” Paying a spell’s conspire cost follows the rules for 
                    paying additional costs in rules 601.2b and 601.2f–h.
            702.77b If a spell has multiple instances of conspire, each is paid separately and triggers based on its 
                    own payment, not any other instance of conspire.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Conspire.Process");
        }
    }
}
