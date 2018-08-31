using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Effect_Interfaces;
using MTG.Model.Abilities._Base;
using MTG.Model.Mana_Objects;
using System;

namespace MTG.Model.Abilities.Activated
{
    public class EffectGenerator:ActivatedAbility
    {
        #region Properties
        public Type EffectType { get; private set; }
        public ITargetRequirements TargetRequirements { get; private set; }
        #endregion

        #region Constructors 
        public EffectGenerator(bool requiresTap, Type effectType, ITargetRequirements targetRequirements, bool removeAtEndOfTurn) : base(requiresTap, removeAtEndOfTurn)
        {
            EffectType = effectType;
            TargetRequirements = targetRequirements;
        }
        public EffectGenerator(bool requiresTap, CastingCost activationCost, Type effectType, ITargetRequirements targetRequirements, bool removeAtEndOfTurn) : this( requiresTap,    effectType,  targetRequirements,  removeAtEndOfTurn)
        {
            EffectType = effectType;
            TargetRequirements = targetRequirements;
        }
        #endregion

        #region Methods
        public virtual IEffect Process(ITarget target)
        {
            return (IEffect)Activator.CreateInstance(EffectType, GamePhase.None, Guid.NewGuid(), target);
        }
        public virtual IEffect Process(ITarget target, GamePhase endingPhase, Guid endingPhaseOwner)
        {
            return (IEffect)Activator.CreateInstance(EffectType, endingPhase, endingPhaseOwner, target);
        }
        #endregion
    }
}
