﻿using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Offering : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Offering
            702.47a Offering is a static ability that functions while the spell with offering is on the stack. 
                    “[Subtype] offering” means “As an additional cost to cast this spell, you may sacrifice a 
                    [subtype] permanent. If you chose to pay the additional cost, this spell’s total cost is 
                    reduced by the sacrificed permanent’s mana cost, and you may cast this spell any time you 
                    could cast an instant.”
            702.47b You choose which permanent to sacrifice as you make choices for the spell (see rule 601.2b), 
                    and you sacrifice that permanent as you pay the total cost (see rule 601.2h).
            702.47c Generic mana in the sacrificed permanent’s mana cost reduces generic mana in the spell’s 
                    total cost. Colored and colorless mana in the sacrificed permanent’s mana cost reduces mana 
                    of the same type in spell’s total cost, and any excess reduces that much generic mana in 
                    spell’s total cost. 
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
