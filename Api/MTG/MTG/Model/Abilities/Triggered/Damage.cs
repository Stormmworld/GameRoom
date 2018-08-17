﻿using MTG.Interfaces;
using MTG.Enumerations;
using System;
using MTG.Model.Objects;
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
        public int Value { get; private set; }
        public Guid Id { get; private set; }
        public List<TargetType> TargetTypes { get; private set; }
        public EffectTrigger Trigger { get { return EffectTrigger.Cast; } }
        #endregion

        #region Constructors
        public Damage()
        {
            Id = Guid.NewGuid();
            TargetTypes = new List<TargetType>();
        }
        public Damage(int value, List<TargetType> targetTypes):this()
        {
            Value = value;
            TargetTypes.AddRange(targetTypes);
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