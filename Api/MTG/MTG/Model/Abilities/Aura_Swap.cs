using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Aura_Swap : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Aura_swap
            702.64a Aura swap is an activated ability of some Aura cards. “Aura swap [cost]” 
                    means “[Cost]: You may exchange this permanent with an Aura card in your hand.”
            702.64b If either half of the exchange can’t be completed, the ability has no effect.
                Example: You activate the aura swap ability of an Aura. The only Aura card in your 
                        hand can’t enchant the permanent that’s enchanted by the Aura with aura 
                        swap. The ability has no effect.
                Example: You activate the aura swap ability of an Aura that you control but you 
                        don’t own. The ability has no effect.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
