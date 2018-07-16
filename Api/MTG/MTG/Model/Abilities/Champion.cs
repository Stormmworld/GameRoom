using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Champion : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Champion
            702.71a Champion represents two triggered abilities. “Champion an [object]” means “When this 
                    permanent enters the battlefield, sacrifice it unless you exile another [object] you 
                    control” and “When this permanent leaves the battlefield, return the exiled card to 
                    the battlefield under its owner’s control.”
            702.71b The two abilities represented by champion are linked. See rule 607, “Linked Abilities.”
            702.71c A permanent is “championed” by another permanent if the latter exiles the former as 
                    the direct result of a champion ability.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
