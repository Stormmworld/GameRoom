using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Poisonous : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Poisonous
            702.69a Poisonous is a triggered ability. “Poisonous N” means “Whenever this 
                    creature deals combat damage to a player, that player gets N poison 
                    counters.” (For information about poison counters, see rule 104.3d.)
            702.69b If a creature has multiple instances of poisonous, each triggers separately.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
