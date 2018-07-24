using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Dethrone : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Dethrone
            702.104a Dethrone is a triggered ability. “Dethrone” means “Whenever this creature 
                    attacks the player with the most life or tied for most life, put a +1/+1 
                    counter on this creature.”
            702.104b If a creature has multiple instances of dethrone, each triggers separately.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Dethrone.Process");
        }
    }
}
