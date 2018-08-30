using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Casting
{
    public class CounterSpell:CastingAbility
    {
        #region Constructors
        public CounterSpell(ICastingCost castingCost, ITarget target, bool isAddOn) : base(castingCost, target, isAddOn)
        {

        }
        public CounterSpell(ICastingCost castingCost, ITargetRequirements targetRequirements, bool isAddOn) : base(castingCost, targetRequirements, isAddOn)
        {

        }
        #endregion
    }
}
