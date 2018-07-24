using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Transmute : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Transmute
            702.52a Transmute is an activated ability that functions only while the card with transmute is in a player’s 
                    hand. “Transmute [cost]” means “[Cost], Discard this card: Search your library for a card with the 
                    same converted mana cost as the discarded card, reveal that card, and put it into your hand. Then 
                    shuffle your library. Activate this ability only any time you could cast a sorcery.”
            702.52b Although the transmute ability can be activated only if the card is in a player’s hand, it continues 
                    to exist while the object is on the battlefield and in all other zones. Therefore objects with transmute 
                    will be affected by effects that depend on objects having one or more activated abilities.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Transmute.Process");
        }
    }
}
