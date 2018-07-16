using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Indestructible : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Indestructible
            702.12a Indestructible is a static ability.
            702.12b A permanent with indestructible can’t be destroyed. Such permanents aren’t 
                    destroyed by lethal damage, and they ignore the state-based action that 
                    checks for lethal damage (see rule 704.5g).
            702.12c Multiple instances of indestructible on the same permanent are redundant.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
