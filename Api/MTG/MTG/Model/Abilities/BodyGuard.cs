using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Bodyguard : IAbility
    {
        /*
            10/4/2004	If a creature is blocked but Trample damage is still done to a player, this damage can’t be 
                        redirected to the Bodyguard because the Bodyguard only takes damage from unblocked creatures.
            10/4/2004	Damage goes to the Bodyguard as long as he is untapped. This works even if he is blocking.
            10/4/2004	If you have multiple Veteran Bodyguards, you can decide which one receives the redirected 
                        damage each time damage would be dealt to you.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
