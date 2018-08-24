using MTG.Interfaces;
using MTG.Enumerations;
using System;
using System.Collections.Generic;
using MTG.ArgumentDefintions.Triggered_Ability_Arguments;
using MTG.ArgumentDefintions.Event_Arguments;
using MTG.Interfaces.Ability_Interfaces;

namespace MTG.Model.Abilities.Triggered
{
    public class Damage : ITriggeredAbility
    {
        /*
        * Damage
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public Guid BoundCardId { get; set; }
        public Guid Id { get; private set; }
        public List<TargetType> TargetTypes { get; private set; }
        public EffectTrigger Trigger { get; private set; }
        public int Value { get; private set; }
        #endregion

        #region Constructors
        private Damage()
        {
            Id = Guid.NewGuid();
            TargetTypes = new List<TargetType>();
        }
        public Damage(int value, List<TargetType> targetTypes, EffectTrigger trigger) : this()
        {
            Trigger = trigger;
            Value = value;
            TargetTypes.AddRange(targetTypes);
        }
        public Damage(int value, List<TargetType> targetTypes, EffectTrigger trigger, Guid boundCardId) : this(value, targetTypes, trigger)
        {
            BoundCardId = boundCardId;
        }
        #endregion

        #region Methods
        public void Process(ITriggeredAbilityArgs e)
        {
            DamageTriggeredAbilityArgs args = (DamageTriggeredAbilityArgs)e;
            OnEffectTriggered?.Invoke(this, new ApplyDamageEventArgs() { DamageValue = Value, Target = args.Target});
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}