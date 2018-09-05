using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities._Base;
using MTG.Model.Data_Objects;

namespace MTG.Model.Abilities.Static
{
    public class AbilityGeneratorStatic: StaticAbility
    {
        #region Properties
        public IAbility Ability { get; private set; }
        public TargetRequirements TargetRequirements { get; private set; }
        #endregion

        #region Constructors
        public AbilityGeneratorStatic(IAbility ability, TargetRequirements targetRequirements)
        {
            Ability = ability;
            TargetRequirements = targetRequirements;
        }
        #endregion
    }
}
