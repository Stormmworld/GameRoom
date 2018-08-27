using MTG.Interfaces.Argument_Interfaces;
using MTG.Interfaces.Mana_Interfaces;

namespace MTG.Interfaces.Ability_Interfaces
{
    public interface IActivatedAbility : IAbility
    {
        #region Properties
        ICastingCost ActivationCost { get; }
        bool RequiresTap { get; }
        #endregion

        #region Methods
        bool Activate(IActivatedAbilityArguments args);
        #endregion
    }
}
