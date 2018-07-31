using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Replicate : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Replicate
            702.55a Replicate is a keyword that represents two abilities. The first is a static 
                    ability that functions while the spell with replicate is on the stack. The 
                    second is a triggered ability that functions while the spell with replicate 
                    is on the stack. “Replicate [cost]” means “As an additional cost to cast 
                    this spell, you may pay [cost] any number of times” and “When you cast this 
                    spell, if a replicate cost was paid for it, copy it for each time its 
                    replicate cost was paid. If the spell has any targets, you may choose new 
                    targets for any of the copies.” Paying a spell’s replicate cost follows 
                    the rules for paying additional costs in rules 601.2b and 601.2f–h.
            702.55b If a spell has multiple instances of replicate, each is paid separately and 
                    triggers based on the payments made for it, not any other instance of 
                    replicate.
        */
        #region Properties
        public EffectTrigger Trigger { get { return EffectTrigger.Cast; } }
        #endregion

        #region Methods
        public AbilityProcessedEventArgs Process(AbilityArgs args)
        {
            throw new NotImplementedException("Scavenge.Process");
        }
        #endregion
    }
}
