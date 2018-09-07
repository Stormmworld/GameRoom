using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Abilities._Base;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities.Activated
{
    public class TargetModifierActivated : ActivatedAbility
    {
        #region Properties
        public ITarget NewTarget { get; private set; }
        public ITargetRequirements NewTargetRequirements { get; private set; }
        public ITarget OriginalTarget { get; private set; }
        public ITargetRequirements OriginalTargetRequirements { get; private set; }
        #endregion

        #region Constructors
        public TargetModifierActivated(bool requiresTap , ITargetRequirements originalTargetRequirements, ITargetRequirements newTargetRequirements) : base(requiresTap, GamePhase.None)
        {
            NewTargetRequirements = newTargetRequirements;
            OriginalTargetRequirements = originalTargetRequirements;
        }
        public TargetModifierActivated(bool requiresTap, List<IManaCost> activationCost, ITargetRequirements originalTargetRequirements, ITargetRequirements newTargetRequirements) : this(requiresTap,  originalTargetRequirements,  newTargetRequirements)
        {
            Add(activationCost);
        }
        #endregion

        #region Methods
        public void Process(ITarget target)
        {
            throw new NotImplementedException("ConvertToCreatureActivated.Process");
        }
        #endregion
    }
}
