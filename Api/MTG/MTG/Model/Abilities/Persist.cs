using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Persist : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Persist
            702.78a Persist is a triggered ability. “Persist” means “When this permanent 
                    is put into a graveyard from the battlefield, if it had no -1/-1 counters 
                    on it, return it to the battlefield under its owner’s control with a 
                    -1/-1 counter on it.”  
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Persist.Process");
        }
    }
}
