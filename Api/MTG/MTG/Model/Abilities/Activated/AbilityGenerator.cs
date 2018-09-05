using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Abilities._Base;
using System;

namespace MTG.Model.Abilities.Activated
{
    public class AbilityGenerator : ActivatedAbility
    {
        #region Properties
        public Type AbilityType { get; private set; }
        public ITargetRequirements TargetRequirements { get; private set; }
        #endregion

        #region Constructors
        public AbilityGenerator(bool requiresTap, Type abilityType, ITargetRequirements targetRequirements, bool removeAtEndOfTurn) : base(requiresTap, removeAtEndOfTurn)
        {
            AbilityType = abilityType;
            TargetRequirements = targetRequirements;
        }
        #endregion

        #region Methods
        public void Process(ITarget target)
        {
            throw new NotImplementedException("AbilityGenerator.Process");
        }
        #endregion
    }
}
