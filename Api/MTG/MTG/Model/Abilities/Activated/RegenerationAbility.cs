using MTG.Model.Abilities._Base;
using MTG.Model.Mana_Objects;

namespace MTG.Model.Abilities.Activated
{
    public class RegenerationAbility: ActivatedAbility
    {
        #region Constructors
        public RegenerationAbility(CastingCost activationCost, bool requiresTap) : base(requiresTap)
        {
            ActivationCost = activationCost;
        }
        #endregion
    }
}
