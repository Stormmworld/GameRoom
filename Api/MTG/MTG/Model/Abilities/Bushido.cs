using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Bushido : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Bushido
            702.44a Bushido is a triggered ability. “Bushido N” means 
                    “Whenever this creature blocks or becomes blocked, 
                    it gets +N/+N until end of turn.” 
                    (See rule 509, “Declare Blockers Step.”)
            702.44b If a creature has multiple instances of bushido, 
                    each triggers separately.             
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Bushido.Process");
        }
    }
}
