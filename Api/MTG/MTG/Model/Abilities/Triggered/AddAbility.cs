using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Triggered
{
    public class AddAbility : TriggeredAbility
    {
        #region Properties
        public IAbility Ability { get; private set; }
        #endregion

        #region Constructors
        public AddAbility(Enumerations.EffectTrigger trigger, IAbility ability) : base(trigger)
        {
            Ability = ability;
        }
        #endregion
    }
}