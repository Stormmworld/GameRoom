using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Eternalize : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Eternalize
            702.128a Eternalize is an activated ability that functions while the card with 
                eternalize is in a graveyard. “Eternalize [cost]” means “[Cost], Exile this card 
                from your graveyard: Create a token that’s a copy of this card, except it’s black, 
                it’s 4/4, it has no mana cost, and it’s a Zombie in addition to its other types. 
                Activate this ability only any time you could cast a sorcery.”
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
