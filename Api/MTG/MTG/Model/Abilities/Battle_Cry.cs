using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Battle_Cry : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Battle_cry
            702.90a Battle cry is a triggered ability. “Battle cry” means “Whenever 
                    this creature attacks, each other attacking creature gets +1/+0 
                    until end of turn.”
            702.90b If a creature has multiple instances of battle cry, each triggers 
                    separately.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
