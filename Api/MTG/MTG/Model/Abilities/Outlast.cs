using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Outlast : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Outlast
             702.106a Outlast is an activated ability. “Outlast [cost]” means “[Cost], 
                    {T}: Put a +1/+1 counter on this creature. Activate this ability 
                    only any time you could cast a sorcery.”
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
