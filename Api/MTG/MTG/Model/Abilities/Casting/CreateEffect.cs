using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Effect_Interfaces;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Abilities._Base;
using System;

namespace MTG.Model.Abilities.Casting
{
    public class CreateEffect:CastingAbility
    {
        #region Properties
        public Type EffectType { get; private set; }
        #endregion

        #region Constructors
        public CreateEffect(ICastingCost castingCost, ITargetRequirements targetRequirements, Type effectType, bool isAddOn) : base(castingCost, targetRequirements, isAddOn)
        {
            EffectType = effectType;
        }
        #endregion

        #region Methods
        public virtual IEffect Process(ITarget target)
        {
            return (IEffect)Activator.CreateInstance(EffectType, GamePhase.None, Guid.NewGuid() , target);
        }
        #endregion
    }
}
