using MTG.Enumerations;
using MTG.Interfaces.Argument_Interfaces;
using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Triggered
{
    public class UpkeepDamage: TriggeredAbility
    {
        #region Properties
        public ITargetRequirements TargetRequirements { get; private set; }
        public IDamage Damage { get; private set; }
        public TargetScope UpkeepScope { get; private set; }
        #endregion

        #region Constructors
        public UpkeepDamage(ITargetRequirements targetRequirements, IDamage damage) :base(EffectTrigger.Phases_BegginingPhase_UpkeepStep)
        {
            Damage = damage;
            TargetRequirements = targetRequirements;
            UpkeepScope = TargetScope.Controller;
        }
        public UpkeepDamage(ITargetRequirements targetRequirements, IDamage damage, TargetScope upkeepScope) : this(targetRequirements, damage)
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
