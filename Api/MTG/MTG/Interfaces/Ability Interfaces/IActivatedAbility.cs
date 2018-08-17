using MTG.Model.Objects;

namespace MTG.Interfaces.Ability_Interfaces
{
    public interface IActivatedAbility : IAbility
    {
        #region Properties
        CastingCost ActivationCost { get; }
        bool RequiresTap { get; }
        #endregion

        #region Methods
        bool Activate(IActivationArgs args);
        #endregion
    }
}
