using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Vigilance : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Vigilance
            702.20a Vigilance is a static ability that modifies the rules for the declare attackers step.
            702.20b Attacking doesn’t cause creatures with vigilance to tap. (See rule 508, “Declare Attackers Step.”)
            702.20c Multiple instances of vigilance on the same creature are redundant.    
        */
        #region Properties
        public EffectTrigger Trigger { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        #region Methods
        public AbilityProcessedEventArgs Process(AbilityArgs args)
        {
            throw new NotImplementedException("Vigilance.Process");
        }
        #endregion
    }
}
