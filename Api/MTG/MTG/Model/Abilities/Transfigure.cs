using MTG.ArgumentDefintions;
using MTG.Enumerations;
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
        #region Properties
        public EffectTrigger Trigger { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        #region Methods
        public AbilityProcessedEventArgs Process(AbilityArgs args)
        {
            throw new NotImplementedException("Transfigure.Process");
        }
        #endregion
    }
}
