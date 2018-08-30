using MTG.Model.Abilities._Base;
using MTG.Model.Mana_Objects;
using System.Collections.Generic;

namespace MTG.Model.Abilities.Activated
{
    public class ManaSource : ActivatedAbility
    {
        #region Variables
        private List<Mana> _ManaProduction;
        #endregion

        #region Propreties
        public IReadOnlyCollection<Mana> ManaProduction { get { return _ManaProduction.AsReadOnly(); } }
        public bool RequiresSacrifice { get; private set; }
        #endregion

        #region Constructors
        private ManaSource(bool requiresTap) : base(requiresTap)
        {
            _ManaProduction = new List<Mana>();
        }
        public ManaSource(bool requiresTap, List<Mana> manaProduction) : this(requiresTap)
        {
            _ManaProduction.AddRange(manaProduction);
        }
        public ManaSource(bool requiresTap, List<Mana> manaProduction, bool requiresSacrifice) : this(requiresTap, manaProduction)
        {
            RequiresSacrifice = requiresSacrifice;
        }
        public ManaSource(bool requiresTap, List<Mana> manaProduction, CastingCost activationCost) : this(requiresTap, manaProduction)
        {
            ActivationCost = activationCost;
        }
        public ManaSource(bool requiresTap, List<Mana> manaProduction, CastingCost activationCost, bool requiresSacrifice) : this(requiresTap, manaProduction, activationCost)
        {
            RequiresSacrifice = requiresSacrifice;
        }
        #endregion
    }
}
