using MTG.Interfaces.Data_Interfaces;
using System;

namespace MTG.Model.Data_Objects
{
    public class FailedUpkeepResult
    {
        #region Properties
        public IDamage Damage { get; private set; }
        public Type EffectType { get; private set; }
        public ITargetRequirements TargetRequirements { get; private set; }
        #endregion

        #region Constructors
        public FailedUpkeepResult(ITargetRequirements targetRequirements, Type effectType )
        {
            EffectType = effectType;
            TargetRequirements = targetRequirements;
        }
        public FailedUpkeepResult(ITargetRequirements targetRequirements, Type effectType, IDamage damage): this(targetRequirements, effectType)
        {
            Damage = damage;
        }
        #endregion
    }
}
