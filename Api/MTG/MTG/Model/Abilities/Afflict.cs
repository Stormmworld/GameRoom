using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Afflict : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Afflict
            702.129a Afflict is a triggered ability. “Afflict N” means “Whenever this 
                    creature becomes blocked, defending player loses N life.”
            702.129b If a creature has multiple instances of afflict, each triggers separately.
        */
        public void ProcessAfflict(AbilityArgs args)
        {
            
            throw new NotImplementedException();
        }
    }
}
