using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Transfigure : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Transfigure
            702.70a Transfigure is an activated ability. “Transfigure [cost]” means “[Cost], Sacrifice this permanent: 
                    Search your library for a creature card with the same converted mana cost as this permanent and 
                    put it onto the battlefield. Then shuffle your library. Activate this ability only any time you 
                    could cast a sorcery.”
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Transfigure.Process");
        }
    }
}
