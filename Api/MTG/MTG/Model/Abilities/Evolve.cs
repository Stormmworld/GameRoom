using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Evolve : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Evolve
            702.99a Evolve is a triggered ability. “Evolve” means “Whenever a creature enters the battlefield under your control, 
                    if that creature’s power is greater than this creature’s power and/or that creature’s toughness is greater than 
                    this creature’s toughness, put a +1/+1 counter on this creature.”
            702.99b A creature “evolves” when one or more +1/+1 counters are put on it as a result of its evolve ability resolving.
            702.99c A creature can’t have a greater power or toughness than a noncreature permanent.
            702.99d If a creature has multiple instances of evolve, each triggers separately.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Evolve.Process");
        }
    }
}
