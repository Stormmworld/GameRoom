using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Effect_Interfaces;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Abilities._Base;
using MTG.Model.Mana_Objects;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities.Casting
{
    public class CreateEffect:CastingAbility
    {
        #region Properties
        public Type EffectType { get; private set; }
        public IDamage Damage { get; internal set; }
        #endregion

        #region Constructors
        public CreateEffect(ICastingCost castingCost, ITargetRequirements targetRequirements, Type effectType, bool isAddOn) : base(castingCost, targetRequirements, isAddOn)
        {
            EffectType = effectType;
        }
        public CreateEffect(ITargetRequirements targetRequirements, Type effectType, bool isAddOn) : this(new CastingCost(), targetRequirements,effectType, isAddOn)
        {

        }
        #endregion

        #region Methods
        public virtual IEffect Process(ITarget target)
        {
            List<object> parameters = new List<object>();
            parameters.Add(target);
            if (Damage != null)
                parameters.Add(Damage);
            return (IEffect)Activator.CreateInstance(EffectType, parameters);
        }
        public virtual IEffect Process(ITarget target, int xValue)
        {
            IEffect effect = Process(target);
            effect.AssignXValue(xValue);
            return effect;
        }
        #endregion
    }
}
