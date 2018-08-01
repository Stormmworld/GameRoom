using MTG.Interfaces;
using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities
{ 
    public class First_Strike : IAbility
    {
        /*
                     * https://mtg.gamepedia.com/First_strike
                        702.7a First strike is a static ability that modifies the rules for the combat damage step.
                                (See rule 510, “Combat Damage Step.”)
                        702.7b If at least one attacking or blocking creature has first strike or double strike 
                                (see rule 702.4) as the combat damage step begins, the only creatures that assign 
                                combat damage in that step are those with first strike or double strike. After that 
                                step, instead of proceeding to the end of combat step, the phase gets a second combat 
                                damage step. The only creatures that assign combat damage in that step are the 
                                remaining attackers and blockers that had neither first strike nor double strike as 
                                the first combat damage step began, as well as the remaining attackers and blockers 
                                that currently have double strike. After that step, the phase proceeds to the end 
                                of combat step.
                        702.7c Giving first strike to a creature without it after combat damage has already been dealt 
                                in the first combat damage step won’t preclude that creature from assigning combat damage 
                                in the second combat damage step. Removing first strike from a creature after it has 
                                already dealt combat damage in the first combat damage step won’t allow it to also 
                                assign combat damage in the second combat damage step (unless the creature has double 
                                strike).
                        702.7d Multiple instances of first strike on the same creature are redundant.             
                    */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Variables
        private List<AbilityType> _Types;
        #endregion

        #region Properties
        public EffectTrigger Trigger { get { return EffectTrigger.CombatProcessDamage_FirstStrike; } }
        public IReadOnlyCollection<AbilityType> Types { get { return _Types.AsReadOnly(); } }
        #endregion

        #region Constructors
        public First_Strike()
        {
            _Types = new List<AbilityType>();
            _Types.Add(AbilityType.Static);
        }
        #endregion

        #region Methods
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("First_Strike.Process");
        }
        #endregion
    }
}
