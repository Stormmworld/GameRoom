using MTG.Enumerations;
using MTG.Interfaces.Argument_Interfaces;

namespace MTG.Interfaces.Ability_Interfaces
{
    public interface ITriggeredAbility : IAbility
    {
        #region Properties
        EffectTrigger Trigger { get; }
        #endregion

        #region Methods
        void Process(ITriggeredAbilityArguments args);
        #endregion
    }
}
