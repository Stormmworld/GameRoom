using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Aftermath : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Aftermath
            702.126a Aftermath is an ability found on some split cards (see rule 708, “Split Cards”). 
                    It represents three static abilities. “Aftermath” means “You may cast this half of 
                    this split card from your graveyard,” “This half of this split card can’t be cast 
                    from any zone other than a graveyard,” and “If this spell was cast from a graveyard, 
                    exile it instead of putting it anywhere else any time it would leave the stack.”
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Aftermath.Process");
        }
    }
}
