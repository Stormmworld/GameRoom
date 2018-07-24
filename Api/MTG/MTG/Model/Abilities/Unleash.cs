using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Unleash : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Unleash
             702.97a Unleash is a keyword that represents two static abilities. “Unleash” means “You may 
                    have this permanent enter the battlefield with an additional +1/+1 counter on it” and 
                    “This permanent can’t block as long as it has a +1/+1 counter on it.”
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Unleash.Process");
        }
    }
}
