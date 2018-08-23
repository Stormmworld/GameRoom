using System;
using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Objects;

namespace MTG.Model.Abilities.Spell
{
    public class DrawCards : ICastingAbility
    {
        #region Events
        public event EventHandler OnPendingActionTriggered,OnEffectTriggered,OnEffectTrigger,OnCardEvent;
        #endregion

        #region Variables
        #endregion

        #region Properties
        public CastingCost CastingCost { get; private set; }
        public Guid Id { get; private set; }
        public bool IsAddOn { get; private set; }
        public bool RequiresTarget { get; private set; }
        public Target Target { get; set; }
        public TargetScope TargetScope { get; private set; }
        public List<TargetType> TargetTypes { get; private set; }
        public int Value { get; private set; }
        #endregion

        #region Constructors
        private DrawCards()
        {
            Id = Guid.NewGuid();
            Target = new Target();
            TargetTypes = new List<TargetType>();
            CastingCost = new CastingCost();
        }
        public DrawCards(int Value, CastingCost castingCost, List<TargetType> targetTypes, TargetScope targetScope, bool requiresTarget):this()
        {
            RequiresTarget = requiresTarget;
            TargetScope = targetScope;
            TargetTypes = targetTypes;
            CastingCost = castingCost;
        }
        #endregion

        #region Event Handlers
        #endregion

        #region Methods
        public void Process()
        {
            throw new NotImplementedException("Process");
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion


    }
}
