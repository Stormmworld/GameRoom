using MTG.Model.Objects;

namespace MTG.Interfaces
{
    public interface IActivatedAbility : IAbility
    {
        #region Properties
        CastingCost ActivationCost { get; }
        #endregion

        #region Methods
        bool Activate(IActivationArgs args);
        #endregion
    }
}
