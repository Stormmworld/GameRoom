using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Fuse : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Fuse
            702.101a Fuse is a static ability found on some split cards (see rule 708, “Split Cards”) that 
                    applies while the card with fuse is in a player’s hand. If a player casts a split card 
                    with fuse from their hand, the player may choose to cast both halves of that split card 
                    rather than choose one half. This choice is made before putting the split card with fuse 
                    onto the stack. The resulting spell is a fused split spell.
            702.101b A fused split spell has the combined characteristics of its two halves. (See rule 708.4.)
            702.101c The total cost of a fused split spell includes the mana cost of each half.
            702.101d As a fused split spell resolves, the controller of the spell follows the instructions of 
                    the left half and then follows the instructions of the right half.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
