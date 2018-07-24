using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Affinity : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Affinity
        702.40a Affinity is a static ability that functions while the spell with affinity is on
        the stack. “Affinity for [text]” means “This spell costs you {1} less to cast for 
        each [text] you control.”
        702.40b If a spell has multiple instances of affinity, each of them applies.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Affinity.Process");
        }
    }
}
