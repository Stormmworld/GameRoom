using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Annihilator: IAbility
    {
        /*
         * https://mtg.gamepedia.com/Annihilator
            702.85a Annihilator is a triggered ability. “Annihilator N” means “Whenever this creature 
                    attacks, defending player sacrifices N permanents.”
            702.85b If a creature has multiple instances of annihilator, each triggers separately.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Annihilator.Process");
        }
    }
}
