using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Melee : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Melee
            702.120a Melee is a triggered ability. “Melee” means “Whenever this creature attacks, 
                    it gets +1/+1 until end of turn for each opponent you attacked with a 
                    creature this combat.”
            702.120b If a creature has multiple instances of melee, each triggers separately. 
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Melee.Process");
        }
    }
}
