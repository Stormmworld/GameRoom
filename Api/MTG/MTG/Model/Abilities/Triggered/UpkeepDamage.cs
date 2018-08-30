using MTG.Enumerations;
using MTG.Interfaces.Argument_Interfaces;
using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Abilities._Base;
using System;

namespace MTG.Model.Abilities.Triggered
{
    public class UpkeepDamage: TriggeredAbility
    {
        #region Properties
        public ITargetRequirements TargetRequirements { get; private set; }
        #endregion

        #region Constructors
        public UpkeepDamage(ITargetRequirements targetRequirements) :base(EffectTrigger.Phases_BegginingPhase_UpkeepStep)
        {
            TargetRequirements = targetRequirements;
        }
        #endregion

        #region Methods
        public virtual void Process(ITriggeredAbilityArguments args)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
