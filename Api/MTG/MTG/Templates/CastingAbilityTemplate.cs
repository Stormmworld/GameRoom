using MTG.Enumerations;
using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;

namespace MTG.Templates
{
    public class CastingAbilityTemplate : ICastingAbility
    {
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public CastingCost CastingCost { get; private set; }
        public Guid Id { get; private set; }
        public bool IsAddOn { get; private set; }
        public bool RequiresTarget { get; private set; }
        public Target Target { get; set; }
        public TargetScope TargetScope { get; private set; }
        public List<TargetType> TargetTypes { get; private set; }
        #endregion

        #region Constructors
        private CastingAbilityTemplate()
        {
            Id = Guid.NewGuid();
            Target = new Target();
            TargetTypes = new List<TargetType>();
            CastingCost = new CastingCost();
        }
        #endregion

        #region Methods
        public void Process()
        {
            throw new NotImplementedException("CastingAbilityTemplate.Process");
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}
