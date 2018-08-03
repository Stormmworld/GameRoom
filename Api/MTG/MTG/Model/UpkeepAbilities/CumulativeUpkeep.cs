using MTG.Interfaces;
using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System;
using System.Collections.Generic;
using MTG.Model.Objects;
using MTG.Model.Pending_Actions;

namespace MTG.Model.UpkeepAbilities
{ 
    public class CumulativeUpkeep : IUpkeepAbility
    {
        /*
         * http://mtg.wikia.com/wiki/Cumulative_Upkeep
             702.23. Cumulative Upkeep

                702.23a. Cumulative upkeep is a triggered ability that imposes an increasing cost on a permanent. "Cumulative upkeep [cost]" means "At the beginning 
                of your upkeep, if this permanent is on the battlefield, put an age counter on this permanent. Then you may pay [cost] for each age counter on it. If 
                you don't, sacrifice it." If [cost] has choices associated with it, each choice is made separately for each age counter, then either the entire set 
                of costs is paid, or none of them is paid. Partial payments aren't allowed.
                702.23b. If a permanent has multiple instances of cumulative upkeep, each triggers separately. However, the age counters are not connected to any 
                particular ability; each cumulative upkeep ability will count the total number of age counters on the permanent at the time that ability resolves.
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Variables
        private UpkeepAction _Action;
        private List<AbilityType> _Types;
        #endregion

        #region Properties
        public UpkeepAction Action
        {
            get
            {
                UpkeepAction action =  new UpkeepAction(_Action);
                action.Multiplier(CumulativeAge);
                return action;
            }
        }
        private int CumulativeAge { get; set; }
        public IAbility FailedUpkeep { get; private set; }
        public Guid Id { get; private set; }
        public EffectTrigger Trigger { get { return EffectTrigger.Phases_BegginingPhase_UpkeepStep; } }
        public AbilityType Type { get { return AbilityType.Triggered; } }
        #endregion

        #region Constructors
        private CumulativeUpkeep()
        {
            Id = Guid.NewGuid();
            _Types = new List<AbilityType>();
            _Types.Add(AbilityType.Triggered);
        }
        public CumulativeUpkeep(UpkeepAction action):this()
        {
            Add(Action);
        }
        public CumulativeUpkeep(IAbility failedUpkeep):this()
        {
            Add(failedUpkeep);
        }
        public CumulativeUpkeep(UpkeepAction action, IAbility failedUpkeep):this(action)
        {
            Add(failedUpkeep);
        }
        #endregion

        #region Methods
        public void Add(IAbility failedUpkeep)
        {
            FailedUpkeep = failedUpkeep;
            failedUpkeep.OnEffectTrigger += OnEffectTrigger;
            failedUpkeep.OnEffectTriggered += OnEffectTriggered;
            failedUpkeep.OnPendingActionTriggered += OnPendingActionTriggered;
        }
        public void Add(UpkeepAction action)
        {
            _Action = action;
        }
        public void CheckResolution(AbilityArgs args)
        {
            if (!Action.Success && FailedUpkeep != null)
                FailedUpkeep.Process(args);
        }
        public void Process(AbilityArgs args)
        {
            args.OriginCard.Add(new Counter() { CounterType = CounterType.Age });
            CumulativeAge = args.OriginCard.GetCountersByType(CounterType.Age).Count;
            if (Action.RequiresInteraction)
            { //create pending action
                UpkeepPendingAction action = new UpkeepPendingAction()
                {
                    Action = this.Action,
                    ActionPlayerId = args.OriginPlayer.Id,
                    CardId = args.OriginCard.Id,
                    UpkeepId = this.Id,
                };
                OnPendingActionTriggered?.Invoke(this, action);
            }
            else
            { //Process Cumulative upkeep
                throw new NotImplementedException("CumulativeUpkeep.Process");
            }
        }
        #endregion
    }
}
