using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Effect_Interfaces;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Abilities._Base;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities.Activated
{
    public class EffectGenerator:ActivatedAbility
    {
        #region Properties
        public Type EffectType { get; private set; }
        public ITargetRequirements TargetRequirements { get; private set; }
        public int EffectValue { get; internal set; }
        public GamePhase RestrictedPhase { get; internal set; }
        #endregion

        #region Constructors 
        public EffectGenerator(bool requiresTap, Type effectType, ITargetRequirements targetRequirements, bool removeAtEndOfTurn) : base(requiresTap, removeAtEndOfTurn)
        {
            EffectType = effectType;
            TargetRequirements = targetRequirements;
        }
        public EffectGenerator(bool requiresTap, List<IManaCost> activationCost, Type effectType, ITargetRequirements targetRequirements, bool removeAtEndOfTurn) : this( requiresTap,    effectType,  targetRequirements,  removeAtEndOfTurn)
        {
            EffectType = effectType;
            TargetRequirements = targetRequirements;
            Add(activationCost);
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
