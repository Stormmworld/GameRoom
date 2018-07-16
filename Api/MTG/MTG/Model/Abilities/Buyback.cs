using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Buyback : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Buyback
            702.26a Buyback appears on some instants and sorceries. It represents two static 
                    abilities that function while the spell is on the stack. “Buyback [cost]” 
                    means “You may pay an additional [cost] as you cast this spell” and “If 
                    the buyback cost was paid, put this spell into its owner’s hand instead 
                    of into that player’s graveyard as it resolves.” Paying a spell’s buyback 
                    cost follows the rules for paying additional costs in rules 601.2b and 601.2f–h.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
