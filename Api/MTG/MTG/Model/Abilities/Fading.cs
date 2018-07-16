using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Fading : IAbility
    {
            /*
             * https://mtg.gamepedia.com/Fading
                702.31a Fading is a keyword that represents two abilities. “Fading N” means “This permanent 
                        enters the battlefield with N fade counters on it” and “At the beginning of your 
                        upkeep, remove a fade counter from this permanent. If you can’t, sacrifice the permanent.”
             */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
