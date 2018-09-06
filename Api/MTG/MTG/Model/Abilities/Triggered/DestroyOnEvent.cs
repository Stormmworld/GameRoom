using MTG.Enumerations;
using MTG.Model.Abilities._Base;
using System;

namespace MTG.Model.Abilities.Triggered
{
    public class DestroyOnEvent : TriggeredAbility
    {
        #region Properties
        public Guid EventCardId { get; private set; }
        public GameEvent GameEvent { get; private set;}
        #endregion

        #region Constructors
        public DestroyOnEvent(EffectTrigger trigger, GameEvent gameEvent, Guid eventCardId) : base(trigger)
        {
            EventCardId = eventCardId;
            GameEvent = gameEvent;
        }
        public DestroyOnEvent(EffectTrigger trigger, GameEvent gameEvent, Guid eventCardId, GamePhase removeAtPhase) : base(trigger, removeAtPhase)
        {
            EventCardId = eventCardId;
            GameEvent = gameEvent;
        }
        #endregion
    }
}