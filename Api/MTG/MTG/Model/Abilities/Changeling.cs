using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Changeling : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Changeling
            702.72a Changeling is a characteristic-defining ability. “Changeling” 
                    means “This object is every creature type.” This ability works 
                    everywhere, even outside the game. See rule 604.3.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Changeling.Process");
        }
    }
}
