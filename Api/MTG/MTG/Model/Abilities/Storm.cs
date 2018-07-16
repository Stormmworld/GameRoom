﻿using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Storm : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Storm
            702.39a Storm is a triggered ability that functions on the stack. “Storm” means “When you cast this spell, 
                    copy it for each other spell that was cast before it this turn. If the spell has any targets, 
                    you may choose new targets for any of the copies.”
            702.39b If a spell has multiple instances of storm, each triggers separately.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
