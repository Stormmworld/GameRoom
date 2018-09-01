using MTG.Interfaces.Argument_Interfaces;
using MTG.Interfaces.Mana_Interfaces;
using System.Collections.Generic;

namespace MTG.Interfaces.Ability_Interfaces
{
    public interface IActivatedAbility : IAbility
    {
        #region Collection Properties
        IReadOnlyList<IManaCost> ActivationCost { get; }
        #endregion

        #region Properties
        bool RequiresTap { get; }
        #endregion

        #region Methods
        bool Activate(IActivatedAbilityArguments args);
        #endregion
    }
}
