using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Epic : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Epic
            702.49a Epic represents two spell abilities, one of which creates a delayed triggered ability. 
                    “Epic” means “For the rest of the game, you can’t cast spells,” and “At the beginning 
                    of each of your upkeeps for the rest of the game, copy this spell except for its epic
                    ability. If the spell has any targets, you may choose new targets for the copy.” See 
                    rule 706.10.
            702.49b A player can’t cast spells once a spell with epic they control resolves, but effects 
                    (such as the epic ability itself) can still put copies of spells onto the stack.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
