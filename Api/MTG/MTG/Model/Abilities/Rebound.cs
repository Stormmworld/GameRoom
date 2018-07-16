using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Rebound : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Rebound
            702.87a Rebound appears on some instants and sorceries. It represents a static ability that 
                    functions while the spell is on the stack and may create a delayed triggered ability. 
                    “Rebound” means “If this spell was cast from your hand, instead of putting it into 
                    your graveyard as it resolves, exile it and, at the beginning of your next upkeep, 
                    you may cast this card from exile without paying its mana cost.”
            702.87b Casting a card without paying its mana cost as the result of a rebound ability 
                    follows the rules for paying alternative costs in rules 601.2b and 601.2f–h.
            702.87c Multiple instances of rebound on the same spell are redundant.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
