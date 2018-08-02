﻿using MTG.Interfaces;
using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities
{ 
    public class Double_Strike : IAbility
    {
        /*
                 * https://mtg.gamepedia.com/Double_strike
                    702.4a Double strike is a static ability that modifies the rules for the combat damage step. 
                            (See rule 510, “Combat Damage Step.”)
                    702.4b If at least one attacking or blocking creature has first strike (see rule 702.7) or 
                            double strike as the combat damage step begins, the only creatures that assign combat 
                            damage in that step are those with first strike or double strike. After that step, 
                            instead of proceeding to the end of combat step, the phase gets a second combat damage 
                            step. The only creatures that assign combat damage in that step are the remaining 
                            attackers and blockers that had neither first strike nor double strike as the first 
                            combat damage step began, as well as the remaining attackers and blockers that currently 
                            have double strike. After that step, the phase proceeds to the end of combat step.
                    702.4c Removing double strike from a creature during the first combat damage step will stop it 
                            from assigning combat damage in the second combat damage step.
                    702.4d Giving double strike to a creature with first strike after it has already dealt combat 
                            damage in the first combat damage step will allow the creature to assign combat damage 
                            in the second combat damage step.
                    702.4e Multiple instances of double strike on the same creature are redundant.
                 */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Properties
        public EffectTrigger Trigger { get { return EffectTrigger.Phases_CombatPhase_CombatDamageStep_FirstStrikeDamage; } }
        public AbilityType Type { get { return AbilityType.Static; } }
        #endregion

        #region Constructors
        public Double_Strike()
        {
        }
        #endregion

        #region Methods
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Double_Strike.Process");
        }
        #endregion
    }
}
