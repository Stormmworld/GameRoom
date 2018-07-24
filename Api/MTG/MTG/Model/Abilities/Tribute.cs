using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Tribute : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Tribute
            702.103a Tribute is a static ability that functions as the creature with tribute is entering the battlefield. 
                    “Tribute N” means “As this creature enters the battlefield, choose an opponent. That player may put 
                    an additional N +1/+1 counters on it as it enters the battlefield.”
            702.103b Objects with tribute have triggered abilities that check “if tribute wasn’t paid.” This condition 
                    is true if the opponent chosen as a result of the tribute ability didn’t have the creature enter the 
                    battlefield with +1/+1 counters as specified by the creature’s tribute ability.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Tribute.Process");
        }
    }
}
