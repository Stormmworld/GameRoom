using MTG.Enumerations;
using MTG.Interfaces.Argument_Interfaces;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Triggered
{
    public class LoseControl:TriggeredAbility
    {
        #region Constructors
        public LoseControl(EffectTrigger trigger):base(trigger)
        {

        }
        #endregion

        #region Methods
        public override void Process(ITriggeredAbilityArguments args)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
