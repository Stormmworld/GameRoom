using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Unearth : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Unearth
             702.83a Unearth is an activated ability that functions while the card with unearth is in a graveyard. 
                    “Unearth [cost]” means “[Cost]: Return this card from your graveyard to the battlefield. It 
                    gains haste. Exile it at the beginning of the next end step. If it would leave the battlefield, 
                    exile it instead of putting it anywhere else. Activate this ability only any time you could 
                    cast a sorcery.”
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Unearth.Process");
        }
    }
}
