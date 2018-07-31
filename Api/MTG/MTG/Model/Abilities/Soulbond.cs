using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Soulbond : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Soulbond
            702.94a Soulbond is a keyword that represents two triggered abilities. “Soulbond” means “When this creature 
                    enters the battlefield, if you control both this creature and another creature and both are unpaired, 
                    you may pair this creature with another unpaired creature you control for as long as both remain 
                    creatures on the battlefield under your control” and “Whenever another creature enters the battlefield 
                    under your control, if you control both that creature and this one and both are unpaired, you may pair 
                    that creature with this creature for as long as both remain creatures on the battlefield under your 
                    control.”
            702.94b A creature becomes “paired” with another as the result of a soulbond ability. Abilities may refer 
                    to a paired creature, the creature another creature is paired with, or whether a creature is paired. 
                    An “unpaired” creature is one that is not paired.
            702.94c When the soulbond ability resolves, if either object that would be paired is no longer a creature, 
                    no longer on the battlefield, or no longer under the control of the player who controls the soulbond 
                    ability, neither object becomes paired.
            702.94d A creature can be paired with only one other creature.
            702.94e A paired creature becomes unpaired if any of the following occur: another player gains control of 
                    it or the creature it’s paired with; it or the creature it’s paired with stops being a creature; or 
                    it or the creature it’s paired with leaves the battlefield.
        */
        #region Properties
        public EffectTrigger Trigger { get { return EffectTrigger.EntersBattleField; } }
        #endregion

        #region Methods
        public AbilityProcessedEventArgs Process(AbilityArgs args)
        {
            throw new NotImplementedException("Soulshift.Process");
        }
        #endregion
    }
}
