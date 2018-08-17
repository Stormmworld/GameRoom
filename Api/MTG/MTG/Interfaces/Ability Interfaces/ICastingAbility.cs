using MTG.Enumerations;
using MTG.Model.Objects;
using System.Collections.Generic;

namespace MTG.Interfaces.Ability_Interfaces
{
    public interface ICastingAbility : IAbility
    {
        #region Properties
        CastingCost CastingCost { get; }
        bool IsAddOn { get; }
        bool RequiresTarget { get; }
        TargetScope TargetScope { get; }
        List<TargetType> TargetTypes { get; }
        #endregion

        #region Methods
        bool Cast(Target target);
        #endregion
    }
}
