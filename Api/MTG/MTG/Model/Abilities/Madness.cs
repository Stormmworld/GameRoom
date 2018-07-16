﻿using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Madness : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Madness
            702.34a Madness is a keyword that represents two abilities. The first is a static ability that functions 
                    while the card with madness is in a player’s hand. The second is a triggered ability that 
                    functions when the first ability is applied. “Madness [cost]” means “If a player would discard 
                    this card, that player discards it, but exiles it instead of putting it into their graveyard” 
                    and “When this card is exiled this way, its owner may cast it by paying [cost] rather than 
                    paying its mana cost. If that player doesn’t, they put this card into their graveyard.”
            702.34b Casting a spell using its madness ability follows the rules for paying alternative costs in rules 601.2b and 601.2f–h.
            702.34c After resolving a madness triggered ability, if the exiled card wasn’t cast and was moved to a public zone, effects referencing the discarded card can find that card. See rule 400.7i.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
