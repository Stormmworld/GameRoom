using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Frenzy : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Frenzy
            702.67a Frenzy is a triggered ability. “Frenzy N” means “Whenever 
                    this creature attacks and isn’t blocked, it gets +N/+0 until 
                    end of turn.”
            702.67b If a creature has multiple instances of frenzy, each triggers 
                    separately. 
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Frenzy.Process");
        }
    }
}
