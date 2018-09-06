using MTG.Enumerations;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Triggered
{
    public class ExileOnEvent: TriggeredAbility
    {
        #region Constructors
        public ExileOnEvent(EffectTrigger trigger, GamePhase removeAtPhase) : base(trigger, removeAtPhase)
        {

        }
        #endregion
    }
}
