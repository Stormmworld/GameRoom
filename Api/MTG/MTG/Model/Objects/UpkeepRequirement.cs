﻿using MTG.Enumerations;

namespace MTG.Model.Objects
{
    public class UpkeepRequirement
    {
        #region Properties
        public int RequirementPlayerId {get;set;}
        public TargetType FailedTarget { get; set; }
        public int FailedTargetId { get; set; }
        public UpkeepRequirementTypes FailedRequirementResult { get; set; }
        public int FailedValue { get; set; }
        public bool Optional { get; set; }
        public int OwnerId { get; set; }
        public TargetType Target { get; set; }
        public TargetScope TargetScope { get; set; }
        public TargetType TargetType { get; set; }
        public int TargetId { get; set; }
        public bool RequiresSelection { get; set; }
        public UpkeepRequirementTypes RequirementType { get; set; }
        public int RequirementValue { get; set; }
        #endregion

        #region Constructors
        public UpkeepRequirement()
        {
        }
        #endregion

        #region Methods
        public UpkeepRequirement Clone()
        {
            return new UpkeepRequirement()
            {
                FailedRequirementResult = this.FailedRequirementResult,
                FailedTarget = this.FailedTarget,
                FailedTargetId = this.FailedTargetId,
                FailedValue = this.FailedValue,
                Optional = this.Optional,
                RequirementPlayerId = this.RequirementPlayerId,
                RequirementType = this.RequirementType,
                RequirementValue = this.RequirementValue,
                RequiresSelection = this.RequiresSelection,
                Target = this.Target,
                TargetId = this.TargetId,
                TargetType = this.TargetType,
                TargetScope = this.TargetScope,
            };
        }
        #endregion
    }
}
