using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Static
{
    public class CastingCostModifier : StaticAbility
    {
        #region Constructors
        public CastingCostModifier(ICastingCost addedCost, ITargetRequirements targetRequirements)
        {
        }
        #endregion
    }
}
