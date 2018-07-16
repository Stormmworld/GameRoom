using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Ingest : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Ingest
            702.114a Ingest is a triggered ability. “Ingest” means “Whenever this creature 
                    deals combat damage to a player, that player exiles the top card of their 
                    library.”
            702.114b If a creature has multiple instances of ingest, each triggers separately.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
