﻿using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Enchant : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Enchant
            702.5a Enchant is a static ability, written “Enchant [object or player].” The 
                    enchant ability restricts what an Aura spell can target and what an Aura 
                    can enchant.
            702.5b For more information about Auras, see rule 303, “Enchantments.”
            702.5c If an Aura has multiple instances of enchant, all of them apply. The 
                    Aura’s target must follow the restrictions from all the instances of 
                    enchant. The Aura can enchant only objects or players that match all
                    of its enchant abilities.
            702.5d Auras that can enchant a player can target and be attached to players. 
                    Such Auras can’t target permanents and can’t be attached to permanents.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
