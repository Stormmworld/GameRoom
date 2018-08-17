using MTG.Enumerations;
using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities.Spell
{
    public class Damage : ICastingAbility
    {
        /*
        * Damage
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public CastingCost CastingCost { get; private set; }
        public Guid Id { get; private set; }
        public List<TargetType> TargetTypes { get; private set; }
        public TargetScope TargetScope { get; private set; }
        public bool RequiresTarget { get; private set; }
        public int Value { get; private set; }
        public bool IsAddOn => throw new NotImplementedException();
        #endregion

        #region Constructors
        private Damage()
        {
            Id = Guid.NewGuid();
            TargetTypes = new List<TargetType>();
            CastingCost = new CastingCost();
        }
        public Damage(int value, TargetScope targetScope, List<TargetType> targetTypes, bool requiresTarget, CastingCost castingCost) : this()
        {
            CastingCost = castingCost;
            RequiresTarget = requiresTarget;
            TargetScope = targetScope;
            TargetTypes.AddRange(targetTypes);
            Value = value;
        }
        #endregion

        #region Methods
        public bool Process(Target target)
        {
            throw new NotImplementedException("Damage.Cast");
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}