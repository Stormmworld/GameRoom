using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Devoid : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Devoid
         702.113a Devoid is a characteristic-defining ability. “Devoid” means “This object is colorless.” This 
                ability functions everywhere, even outside the game. See rule 604.3.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
