using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Shadow : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Shadow
            702.27a Shadow is an evasion ability.
            702.27b A creature with shadow can’t be blocked by creatures without shadow, and a 
                    creature without shadow can’t be blocked by creatures with shadow. (See 
                    rule 509, “Declare Blockers Step.”)
            702.27c Multiple instances of shadow on the same creature are redundant.
        */
        #region Properties
        public EffectTrigger Trigger { get { return EffectTrigger.DeclareBlockersPhase; } }
        #endregion

        #region Methods
        public AbilityProcessedEventArgs Process(AbilityArgs args)
        {
            throw new NotImplementedException("Shadow.Process");
        }
        #endregion
    }
}
