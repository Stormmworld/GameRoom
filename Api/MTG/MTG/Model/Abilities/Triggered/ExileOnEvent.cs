using MTG.Enumerations;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Triggered
{
    public class ExileOnEvent: TriggeredAbility
    {
        #region Constructors
        public ExileOnEvent(EffectTrigger trigger, bool removeAtEndOfTurn) : base(trigger, removeAtEndOfTurn)
        {

        }
        #endregion
    }
}
