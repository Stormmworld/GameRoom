using MTG.Enumerations;
using MTG.Interfaces.Ability_Interfaces;
using MTG.Interfaces.Argument_Interfaces;

namespace MTG.Model.Abilities._Base
{
    public class TriggeredAbility : Ability, ITriggeredAbility
    {
        #region Properties
        public EffectTrigger Trigger { get; private set; }
        #endregion

        #region Constructors
        internal TriggeredAbility(EffectTrigger trigger)
        {
            Trigger = trigger;
        }
        #endregion

        #region Methods
        public virtual void Process(ITriggeredAbilityArguments args)
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            return GetType().Name;
        }
        #endregion
    }
}
