using MTG.Interfaces.Ability_Interfaces;
using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Casting
{
    public class CreateAbility : CastingAbility
    {
        #region Properties
        public IAbility Ability { get; private set; }
        #endregion

        #region Constructors
        public CreateAbility(ICastingCost castingCost, ITarget target, bool isAddOn, IAbility ability) : base(castingCost, target, isAddOn)
        {
            Ability = ability;
        }
        public CreateAbility(ICastingCost castingCost, ITargetRequirements targetRequirements, bool isAddOn, IAbility ability) : base(castingCost, targetRequirements, isAddOn)
        {
            Ability = ability;
        }
        #endregion
    }
}
