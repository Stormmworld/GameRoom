using MTG.Enumerations;

namespace MTG.Interfaces.Data_Interfaces
{
    public interface ITargetRequirements
    {
        #region Collection Properties
        TargetType TargetType { get; }
        #endregion

        #region Properties
        TargetScope TargetScope { get; }
        ITargetCardRequirements TargetCardRequirements { get; }
        #endregion
    }
}
