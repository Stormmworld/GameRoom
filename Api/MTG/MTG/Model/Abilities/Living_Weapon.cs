using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Living_Weapon : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Living_weapon
            702.91a Living weapon is a triggered ability. “Living weapon” means “When this Equipment enters 
                    the battlefield, create a 0/0 black Germ creature token, then attach this Equipment to it.”
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
