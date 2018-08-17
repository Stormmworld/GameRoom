using MTG.Enumerations;
using MTG.Model.Objects;

namespace MTG.Interfaces.Ability_Interfaces
{
    public interface ITriggeredAbility : IAbility
    {
        #region Properties
        EffectTrigger Trigger { get; }
        #endregion

        #region Methods
        void Process(ITriggeredAbilityArgs args);
        #endregion
    }
}
