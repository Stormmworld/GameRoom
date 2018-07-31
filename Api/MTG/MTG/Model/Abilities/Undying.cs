using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Undying : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Undying
             702.92a Undying is a triggered ability. “Undying” means “When this permanent is put into a graveyard 
                    from the battlefield, if it had no +1/+1 counters on it, return it to the battlefield under 
                    its owner’s control with a +1/+1 counter on it.”
        */
        #region Properties
        public EffectTrigger Trigger { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        #region Methods
        public AbilityProcessedEventArgs Process(AbilityArgs args)
        {
            throw new NotImplementedException("Undying.Process");
        }
        #endregion
    }
}
