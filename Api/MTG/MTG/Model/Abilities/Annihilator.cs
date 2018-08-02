using MTG.Interfaces;
using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities
{ 
    public class Annihilator : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Annihilator
            702.85a Annihilator is a triggered ability. “Annihilator N” means “Whenever this creature 
                    attacks, defending player sacrifices N permanents.”
            702.85b If a creature has multiple instances of annihilator, each triggers separately.
         */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Properties
        public EffectTrigger Trigger { get { return EffectTrigger.Phases_CombatPhase_BeginningStep; } }
        public AbilityType Type { get { return AbilityType.Static; } }
        #endregion

        #region Constructors
        public Annihilator()
        {

        }
        #endregion

        #region Methods
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Annihilator.Process");
        }
        #endregion
    }
}
