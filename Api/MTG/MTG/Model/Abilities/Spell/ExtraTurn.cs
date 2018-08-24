using MTG.Enumerations;
using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities.Spell
{
    public class ExtraTurn : ICastingAbility
    {
        /*
        * Damage
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public Guid BoundCardId { get; set; }
        public CastingCost CastingCost { get; private set; }
        public Guid Id { get; private set; }
        public bool IsAddOn { get; private set; }
        public Card OriginCard { get; set; }
        public bool RequiresTarget { get; private set; }
        public Target Target { get; set; }
        public List<TargetType> TargetTypes { get; private set; }
        public TargetScope TargetScope { get; private set; }
        public int Value { get; private set; }
        #endregion

        #region Constructors
        private ExtraTurn()
        {
            Id = Guid.NewGuid();
            TargetTypes = new List<TargetType>();
            CastingCost = new CastingCost();
        }
        public ExtraTurn(int value, TargetScope targetScope, List<TargetType> targetTypes, bool requiresTarget, CastingCost castingCost, Card originCard) : this()
        {
            CastingCost = castingCost;
            RequiresTarget = requiresTarget;
            TargetScope = targetScope;
            TargetTypes.AddRange(targetTypes);
            Value = value;
            OriginCard = originCard;
        }
        #endregion

        #region Methods
        public void Process()
        {
            //send effect for extra turn
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}