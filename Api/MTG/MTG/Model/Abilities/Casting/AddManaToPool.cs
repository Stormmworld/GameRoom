using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Abilities._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Mana_Objects;
using System.Collections.Generic;

namespace MTG.Model.Abilities.Casting
{
    public class AddManaToPool: CastingAbility
    {
        #region Variables
        private List<IMana> _ManaToAdd;
        #endregion

        #region Collection Propreties
        public IReadOnlyCollection<IMana> ManaToAdd { get { return _ManaToAdd.AsReadOnly(); } }
        #endregion

        #region Constructors
        public AddManaToPool(ICastingCost castingCost, List<IMana> manaToAdd, bool isAddOn) : base(castingCost, new TargetRequirements( Enumerations.TargetScope.Self, new List<Enumerations.TargetType>() { Enumerations.TargetType.Player}), isAddOn)
        {
            _ManaToAdd.AddRange(manaToAdd);
        }
        #endregion
    }
}
