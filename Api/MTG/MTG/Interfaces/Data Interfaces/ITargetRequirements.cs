using MTG.Enumerations;
using System.Collections.Generic;

namespace MTG.Interfaces.Data_Interfaces
{
    public interface ITargetRequirements
    {
        #region Collection Properties
        IReadOnlyList<TargetType> TargetTypes { get; }
        #endregion

        #region Properties
        TargetScope TargetScope { get; }
        ITargetCardRequirements TargetCardRequirements { get; }
        #endregion
    }
}
