using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Renown : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Renown
            702.111a Renown is a triggered ability. “Renown N” means “When this creature deals combat damage 
                    to a player, if it isn’t renowned, put N +1/+1 counters on it and it becomes renowned.”
            702.111b Renowned is a designation that has no rules meaning other than to act as a marker that 
                    the renown ability and other spells and abilities can identify. Only permanents can be 
                    or become renowned. Once a permanent becomes renowned, it stays renowned until it leaves 
                    the battlefield. Renowned is neither an ability nor part of the permanent’s copiable values.
            702.111c If a creature has multiple instances of renown, each triggers separately. The first 
                    such ability to resolve will cause the creature to become renowned, and subsequent 
                    abilities will have no effect. (See rule 603.4) 
        */
        #region Properties
        public EffectTrigger Trigger { get { return EffectTrigger.DamageToPlayer; } }
        private bool IsRenowned { get; set; }
        #endregion

        #region Methods
        public AbilityProcessedEventArgs Process(AbilityArgs args)
        {
            if (!IsRenowned)
            {
                //add +1/+1 effect to card
                IsRenowned = true;
            }
            throw new NotImplementedException("Renown.Process");
        }
        #endregion
    }
}
