using MTG.Interfaces.Ability_Interfaces;
using MTG.Enumerations;
using System;
using MTG.Interfaces;
using MTG.Model.Objects;
using System.Collections.Generic;

namespace MTG.Model.Abilities.Triggered
{
    public class Sacrifice : ITriggeredAbility
    {
        /*
        * Destroy
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        public Target Target { get; set; }
        public TargetScope TargetScope { get; private set; }
        public List<TargetType> TargetTypes { get; private set; }
        public EffectTrigger Trigger { get; private set; }
        #endregion

        #region Constructors
        private Sacrifice()
        {
            Id = Guid.NewGuid();
        }
        public Sacrifice(EffectTrigger trigger, TargetScope targetScope, Target target) :this()
        {
            Trigger = trigger;
            TargetScope = targetScope;
            Target = target;
        }
        #endregion

        #region Methods
        public void Process(ITriggeredAbilityArgs args)
        {
            throw new NotImplementedException("Destroy.Process");
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}