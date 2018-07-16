using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Extort : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Extort
            702.100a Extort is a triggered ability. “Extort” means “Whenever you cast a spell, 
                    you may pay {W/B}. If you do, each opponent loses 1 life and you gain life 
                    equal to the total life lost this way.”
            702.100b If a permanent has multiple instances of extort, each triggers separately.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
