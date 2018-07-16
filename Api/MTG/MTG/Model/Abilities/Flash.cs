using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Flash : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Flash
            702.8a Flash is a static ability that functions in any zone from which you could play the card it’s on. “Flash” means “You may play this card any time you could cast an instant.”
            702.8b Multiple instances of flash on the same object are redundant.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
