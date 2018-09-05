using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Casting
{
    public class CopyCard: CastingAbility
    {
        #region Properties
        public ITarget CardToChange { get; private set; }
        public Color NewCardColor { get; internal set; }
        #endregion

        #region Constructors
        public CopyCard(ICastingCost castingCost, ITarget cardToChange, ITarget target, bool isAddOn) : base(castingCost, target, isAddOn)
        {
            CardToChange = cardToChange;
        }
        public CopyCard(ICastingCost castingCost, ITarget cardToChange, ITargetRequirements targetRequirements, bool isAddOn) : base(castingCost, targetRequirements, isAddOn)
        {
            CardToChange = cardToChange;
        }
        #endregion
    }
}
