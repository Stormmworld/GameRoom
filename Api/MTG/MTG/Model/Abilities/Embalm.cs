using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Embalm : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Embalm
            702.127a Embalm is an activated ability that functions while the card with embalm 
                    is in a graveyard. “Embalm [cost]” means “[Cost], Exile this card from your 
                    graveyard: Create a token that’s a copy of this card, except it’s white, it 
                    has no mana cost, and it’s a Zombie in addition to its other types. 
                    Activate this ability only any time you could cast a sorcery.”
            702.127b A token is “embalmed” if it’s created by a resolving embalm ability.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Embalm.Process");
        }
    }
}
