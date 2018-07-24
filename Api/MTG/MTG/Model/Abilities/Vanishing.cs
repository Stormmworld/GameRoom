using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Vanishing : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Vanishing
            702.62a Vanishing is a keyword that represents three abilities. “Vanishing N” means “This 
                    permanent enters the battlefield with N time counters on it,” “At the beginning of 
                    your upkeep, if this permanent has a time counter on it, remove a time counter from 
                    it,” and “When the last time counter is removed from this permanent, sacrifice it.”
            702.62b Vanishing without a number means “At the beginning of your upkeep, if this permanent 
                    has a time counter on it, remove a time counter from it” and “When the last time 
                    counter is removed from this permanent, sacrifice it.”
            702.62c If a permanent has multiple instances of vanishing, each works separately. 
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Vanishing.Process");
        }
    }
}
