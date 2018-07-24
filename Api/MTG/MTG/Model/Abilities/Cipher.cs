﻿using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Cipher : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Cipher
            702.98a Cipher appears on some instants and sorceries. It represents two abilities. The first is a 
                    spell ability that functions while the spell with cipher is on the stack. The second is a 
                    static ability that functions while the card with cipher is in the exile zone. “Cipher” 
                    means “If this spell is represented by a card, you may exile this card encoded on a creature 
                    you control” and “For as long as this card is encoded on that creature, that creature has 
                    ‘Whenever this creature deals combat damage to a player, you may copy the encoded card 
                    and you may cast the copy without paying its mana cost.’”
            702.98b The term “encoded” describes the relationship between the card with cipher while in the 
                    exile zone and the creature chosen when the spell represented by that card resolves.
            702.98c The card with cipher remains encoded on the chosen creature as long as the card with 
                    cipher remains exiled and the creature remains on the battlefield. The card remains 
                    encoded on that object even if it changes controller or stops being a creature, as 
                    long as it remains on the battlefield.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Cipher.Process");
        }
    }
}
