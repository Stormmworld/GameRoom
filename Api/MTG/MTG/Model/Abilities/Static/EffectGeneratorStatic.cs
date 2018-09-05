using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Abilities._Base;
using System;

namespace MTG.Model.Abilities.Static
{
    public class EffectGeneratorStatic: StaticAbility
    {
        #region Properties
        public Type EffectType { get; private set; }
        public ITargetRequirements TargetRequirements { get; private set; }
        #endregion

        #region Constructors
        public EffectGeneratorStatic(Type effectType, ITargetRequirements targetRequirements)
        {
            EffectType = effectType;
            TargetRequirements = targetRequirements;
        }
        #endregion

    }
}
