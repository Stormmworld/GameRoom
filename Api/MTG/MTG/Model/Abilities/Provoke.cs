using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Provoke : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Provoke
            702.38a Provoke is a triggered ability. “Provoke” means “Whenever this creature 
                    attacks, you may choose to have target creature defending player controls 
                    block this creature this combat if able. If you do, untap that creature.”
            702.38b If a creature has multiple instances of provoke, each triggers separately.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
