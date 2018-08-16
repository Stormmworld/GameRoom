using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities.Spell
{
    public class Damage : ISpellAbility
    {
        /*
        * Damage
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        public List<TargetType> TargetTypes { get; private set; }
        public TargetScope TargetScope { get; private set; }
        public bool RequiresTarget { get; private set; }
        public int Value { get; private set; }
        #endregion

        #region Constructors
        private Damage()
        {
            Id = Guid.NewGuid();
            TargetTypes = new List<TargetType>();
        }
        public Damage(int value, TargetScope targetScope, List<TargetType> targetTypes, bool requiresTarget) : this()
        {
            RequiresTarget = requiresTarget;
            TargetScope = targetScope;
            TargetTypes.AddRange(targetTypes);
            Value = value;
        }
        #endregion

        #region Methods
        public void Process(Target e)
        {
            throw new NotImplementedException("Damage.Process");
;        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}