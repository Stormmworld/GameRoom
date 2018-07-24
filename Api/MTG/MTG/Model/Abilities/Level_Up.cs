using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Level_Up : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Level_up
            702.86a Level up is an activated ability. “Level up [cost]” means “[Cost]: Put a 
                    level counter on this permanent. Activate this ability only any time you 
                    could cast a sorcery.”
            702.86b Each card printed with a level up ability is known as a leveler card. It 
                    has a nonstandard layout and includes two level symbols that are themselves 
                    keyword abilities. See rule 710, “Leveler Cards.”  
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Level_Up.Process");
        }
    }
}
