using MTG.Interfaces.Ability_Interfaces;
using MTG.Enumerations;
using System;
using MTG.Interfaces;
using MTG.Model.Objects;

namespace MTG.Model.Abilities.Triggered
{
    public class AbilityGenerator : ITriggeredAbility
    {
        /*
        * AbilityGenerator
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public IAbility Ability { get; private set; }
        public Guid BoundCardId { get; set; }
        public Guid Id { get; private set; }
        public bool RequiresTarget { get; private set; }
        public Target Target { get; set; }
        public TargetScope TargetScope { get; private set; }
        public TargetType TargetType { get; private set; }
        public EffectTrigger Trigger { get; private set; }
        #endregion

        #region Constructors
        private AbilityGenerator()
        {
            Id = Guid.NewGuid();
        }
        public AbilityGenerator(EffectTrigger trigger, IAbility ability, TargetScope targetScope, TargetType targetType) : this()
        {
            Ability = ability;
            RequiresTarget = targetScope == TargetScope.Single;
            TargetScope = targetScope;
            TargetType = targetType;
            Trigger = trigger;
        }
        public AbilityGenerator(EffectTrigger trigger, IAbility ability, TargetScope targetScope, TargetType targetType, Guid boundCardId) : this(trigger, ability, targetScope, targetType)
        {
            BoundCardId = boundCardId;
        }
        public AbilityGenerator(EffectTrigger trigger, IAbility ability, Target target) : this()
        {
            Ability = ability;
            RequiresTarget = true;
            Trigger = trigger;
            Target = target;
        }
        public AbilityGenerator(EffectTrigger trigger, IAbility ability, Target target, Guid boundCardId) : this(trigger, ability, target)
        {
            BoundCardId = boundCardId;
        }
        #endregion

        #region Methods
        public void Process(ITriggeredAbilityArgs args)
        {
            throw new NotImplementedException("AbilityGenerator.Process");
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}