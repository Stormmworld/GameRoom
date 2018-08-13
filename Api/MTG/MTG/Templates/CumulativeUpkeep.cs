using MTG.Interfaces;
using MTG.Enumerations;
using System;
using System.Collections.Generic;
using MTG.Model.Objects;
using MTG.ArgumentDefintions.Triggered_Ability_Arguments;

namespace MTG.Templates
{ 
    public class UpkeepAbilityTemplate : IUpkeepAbility
    {
        /*
         * UpkeepAbilityTemplate
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
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
        public ITriggeredAbility FailedUpkeep { get; private set; }
        public Guid Id { get; private set; }
        public EffectTrigger Trigger { get { return EffectTrigger.Phases_BegginingPhase_UpkeepStep; } }
        public AbilityType Type { get { return AbilityType.Triggered; } }
        #endregion

        #region Constructors
        private UpkeepAbilityTemplate()
        {
            Id = Guid.NewGuid();
            _Types = new List<AbilityType>();
            _Types.Add(AbilityType.Triggered);
        }
        public UpkeepAbilityTemplate(UpkeepAction action):this()
        {
            Add(Action);
        }
        public UpkeepAbilityTemplate(ITriggeredAbility failedUpkeep):this()
        {
            Add(failedUpkeep);
        }
        public UpkeepAbilityTemplate(UpkeepAction action, ITriggeredAbility failedUpkeep):this(action)
        {
            Add(failedUpkeep);
        }
        #endregion

        #region Methods
        public void Add(ITriggeredAbility failedUpkeep)
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
        public void CheckResolution(UpkeepResolutionTriggeredAbilityArgs args)
        {
            if (!Action.Success && FailedUpkeep != null)
                FailedUpkeep.Process(args);
        }
        public void Process(IUpkeepAbilityArgs e)
        {
                throw new NotImplementedException("UpkeepAbilityTemplate.Process");
        }
        #endregion
    }
}
