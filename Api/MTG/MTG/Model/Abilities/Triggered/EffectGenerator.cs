using MTG.Interfaces;
using MTG.Enumerations;
using System;
using MTG.Model.Objects;
using MTG.Interfaces.Ability_Interfaces;

namespace MTG.Model.Abilities.Triggered
{
    public class EffectGenerator : ITriggeredAbility
    {
        /*
        * EffectGenerator
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public Guid BoundCardId { get; set; }
        public IEffect Effect { get; private set; }
        public Guid Id { get; private set; }
        public EffectTrigger Trigger { get; private set; }
        #endregion

        #region Constructors
        private EffectGenerator()
        {
            Id = Guid.NewGuid();
        }
        public EffectGenerator(EffectTrigger trigger,IEffect effect):this()
        {
            Effect = effect;
            Trigger = trigger;
        }
        public EffectGenerator(EffectTrigger trigger, IEffect effect, Guid boundCardId) : this(trigger, effect)
        {
            BoundCardId = boundCardId;
        }
        #endregion

        #region Methods
        public void Process(ITriggeredAbilityArgs args)
        {
            throw new NotImplementedException("PlusXPlusY.Process");
        }
        public ITriggeredAbilityArgs GenerateArgs(ITriggeredAbilityArgs triggeredAbilityArgs, Card originCard)
        {
            throw new NotImplementedException("PlusXPlusY.GenerateArgs");
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}