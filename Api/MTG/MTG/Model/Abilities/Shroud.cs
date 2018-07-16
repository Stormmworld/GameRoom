using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Shroud : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Shroud
            702.18a Shroud is a static ability. “Shroud” means “This permanent or player can’t 
                    be the target of spells or abilities.”
            702.18b Multiple instances of shroud on the same permanent or player are redundant.   
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
