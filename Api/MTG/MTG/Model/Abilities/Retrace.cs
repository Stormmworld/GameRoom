using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Retrace : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Retrace
            702.80a Retrace appears on some instants and sorceries. It represents a static 
                    ability that functions while the card with retrace is in a player’s 
                    graveyard. “Retrace” means “You may cast this card from your graveyard 
                    by discarding a land card as an additional cost to cast it.” Casting a 
                    spell using its retrace ability follows the rules for paying additional 
                    costs in rules 601.2b and 601.2f–h. 
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
