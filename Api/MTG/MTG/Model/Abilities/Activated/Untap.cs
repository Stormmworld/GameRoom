using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Activated
{
    public class Untap: ActivatedAbility
    {
        #region Constructors
        public Untap(bool requiresTap) : base(requiresTap)
        {

        }
        public Untap(bool requiresTap, ICastingCost activationCost) : this(requiresTap)
        {
            ActivationCost = activationCost;
        }
        #endregion
    }
}
