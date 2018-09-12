using MTG.Enumerations;
using MTG.Interfaces.Argument_Interfaces;
using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Abilities._Base;
using MTG.Model.Data_Objects;

namespace MTG.Model.Abilities.Triggered
{
    public class UpkeepSacrifice : TriggeredAbility
    {
        #region Properties
        public ITargetRequirements TargetRequirements { get; private set; }
        public FailedUpkeepResult FailedEffect { get; internal set; }
        public bool Optional { get; private set; }
        public TargetScope UpkeepScope { get; private set; }
        #endregion

        #region Constructors
        public UpkeepSacrifice(ITargetRequirements targetRequirements, bool optional) : base(EffectTrigger.Phases_BegginingPhase_UpkeepStep)
        {
            TargetRequirements = targetRequirements;
            UpkeepScope = TargetScope.Controller;
        }
        public UpkeepSacrifice(ITargetRequirements targetRequirements, bool optional, TargetScope upkeepScope) : this(targetRequirements, optional)
        {
            UpkeepScope = upkeepScope;
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
