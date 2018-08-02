using MTG.Interfaces;
using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System;
using System.Collections.Generic;

namespace MTG.Model.UpkeepAbilities
{ 
    public class CumulativeUpkeep : IUpkeepAbility
    {
        /*
             CumulativeUpkeep
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Variables
        private List<AbilityType> _Types;
        #endregion

        #region Properties
        public IAbility FailedUpkeep { get; private set; }
        public Guid Id { get; private set; }
        public bool Success { get; private set; }
        public bool RequiresInteraction { get; private set; }
        public EffectTrigger Trigger { get { return EffectTrigger.Phases_BegginingPhase_UpkeepStep; } }
        public AbilityType Type { get { return AbilityType.Triggered; } }
        #endregion

        #region Constructors
        public CumulativeUpkeep()
        {
            RequiresInteraction = false;
            Id = Guid.NewGuid();
            _Types = new List<AbilityType>();
            _Types.Add(AbilityType.Triggered);
        }
        public CumulativeUpkeep(IAbility failedUpkeep):this()
        {
            AddFailedAbility(failedUpkeep);
        }
        #endregion

        #region Methods
        public void AddFailedAbility(IAbility failedUpkeep)
        {
            FailedUpkeep = failedUpkeep;
            failedUpkeep.OnEffectTrigger += OnEffectTrigger;
            failedUpkeep.OnEffectTriggered += OnEffectTriggered;
            failedUpkeep.OnPendingActionTriggered += OnPendingActionTriggered;
        }
        public void CheckResolution(AbilityArgs args)
        {
            if (!Success && FailedUpkeep != null)
                FailedUpkeep.Process(args);
        }
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("CumulativeUpkeep.Process");
        }
        #endregion
    }
}
