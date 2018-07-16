using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Fortify : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Fortify
            702.66a Fortify is an activated ability of Fortification cards. “Fortify [cost]” means “[Cost]: 
                    Attach this Fortification to target land you control. Activate this ability only any 
                    time you could cast a sorcery.”
            702.66b For more information about Fortifications, see rule 301, “Artifacts.”
            702.66c If a Fortification has multiple instances of fortify, any of its fortify abilities may be used.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
