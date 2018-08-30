using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Abilities._Base;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities.Triggered
{
    public class CounterRemoval: TriggeredAbility
    {
        #region Variables
        private List<CardAction> _RequiredActionsThisTurn;
        #endregion

        #region Properties
        public ICounter CounterType { get; private set; }
        public IReadOnlyList<CardAction> RequiredActionsThisTurn { get { return _RequiredActionsThisTurn.AsReadOnly(); } }
        #endregion

        #region Constructors
        public CounterRemoval(EffectTrigger trigger, ICounter counterType) :base(trigger)
        {
            _RequiredActionsThisTurn = new List<CardAction>();
            CounterType = counterType;
        }
        public CounterRemoval(EffectTrigger trigger, ICounter counterType, List<CardAction> requiredActions) : this(trigger, counterType)
        {
            _RequiredActionsThisTurn.AddRange(requiredActions);
        }
        #endregion

    }
}
