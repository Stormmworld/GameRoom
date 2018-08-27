using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Casting
{
    public class DrawCards : CastingAbility
    {
        #region Properties
        public int DrawCount { get; private set; }
        #endregion

        #region Constructors
        public DrawCards(int drawCount, ICastingCost castingCost, ITarget target, bool isAddOn) : base(castingCost, target, isAddOn)
        {
            DrawCount = drawCount;
        }
        public DrawCards(int drawCount, ICastingCost castingCost, ITargetRequirements targetRequirements, bool isAddOn) : base(castingCost, targetRequirements, isAddOn)
        {
            DrawCount = drawCount;
        }
        #endregion
    }
}
