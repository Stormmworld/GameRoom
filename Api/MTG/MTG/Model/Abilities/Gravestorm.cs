using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Gravestorm : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Gravestorm
            702.68a Gravestorm is a triggered ability that functions on the stack. “Gravestorm” means 
                    “When you cast this spell, copy it for each permanent that was put into a graveyard
                    from the battlefield this turn. If the spell has any targets, you may choose new 
                    targets for any of the copies.”
            702.68b If a spell has multiple instances of gravestorm, each triggers separately.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
