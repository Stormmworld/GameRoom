using MTG.ArgumentDefintions.Triggered_Ability_Arguments;
using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Objects;

namespace MTG.Interfaces
{
    public interface IUpkeepAbility : IAbility
    {
        #region Properties
        ITriggeredAbility FailedUpkeep { get; }
        UpkeepAction Action { get; }
        #endregion

        #region Methods
        void CheckResolution(UpkeepResolutionTriggeredAbilityArgs args);
        void Process(IUpkeepAbilityArgs e);
        #endregion
    }
}
