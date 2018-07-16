using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Prowess : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Prowess
            702.107a Prowess is a triggered ability. “Prowess” means “Whenever you cast 
                    a noncreature spell, this creature gets +1/+1 until end of turn.”
            702.107b If a creature has multiple instances of prowess, each triggers
                    separately.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
