using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Casting
{
    public class CreateCounter:CastingAbility
    {
        #region Properties
        public ICounter Counter { get; private set; }
        #endregion

        #region Constructors
        public CreateCounter(ICastingCost castingCost, ITarget target, bool isAddOn, ICounter counter) : base(castingCost, target, isAddOn)
        {
            Counter = counter;
        }
        public CreateCounter(ICastingCost castingCost, ITargetRequirements targetRequirements, bool isAddOn, ICounter counter) : base(castingCost, targetRequirements, isAddOn)
        {
            Counter = counter;
        }
        #endregion
    }
}
