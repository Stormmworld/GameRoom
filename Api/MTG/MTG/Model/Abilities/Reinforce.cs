using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Reinforce : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Reinforce
            702.76a Reinforce is an activated ability that functions only while the card with reinforce 
                    is in a player’s hand. “Reinforce N—[cost]” means “[Cost], Discard this card: Put 
                    N +1/+1 counters on target creature.”
            702.76b Although the reinforce ability can be activated only if the card is in a player’s 
                    hand, it continues to exist while the object is on the battlefield and in all 
                    other zones. Therefore objects with reinforce will be affected by effects that 
                    depend on objects having one or more activated abilities.
        */
        #region Properties
        public bool IsActivated { get { return true; } }
        public bool IsStatic { get { return false; } }
        public EffectTrigger Trigger { get { return EffectTrigger.CardInHand; } }        
        #endregion

        #region Methods
        public AbilityProcessedEventArgs Process(AbilityArgs args)
        {
            throw new NotImplementedException("Reinforce.Process");
        }
        #endregion
    }
}
