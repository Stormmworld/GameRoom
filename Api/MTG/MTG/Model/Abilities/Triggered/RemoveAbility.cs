using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Triggered
{
    public class RemoveAbility:TriggeredAbility
    {
        #region Properties
        public IAbility Ability { get; private set; }
        #endregion

        #region Constructors
        public RemoveAbility(Enumerations.EffectTrigger trigger, IAbility ability) : base(trigger)
        {
            Ability = ability;
        }
        #endregion
    }
}
