using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Counters;
using System.Collections.Generic;

namespace MTG.Model.Data_Objects
{
    public class TargetRequirements : ITargetRequirements
    {
        #region Variables
        private List<TargetType> _TargetTypes;
        private TargetScope all;
        private PlusXPlusY plusXPlusY;
        #endregion

        #region Properties
        public TargetScope TargetScope { get; private set; }
        public ITargetCardRequirements TargetCardRequirements { get; private set; }
        public TargetType TargetType { get; private set; }
        #endregion

        #region Constructors
        public TargetRequirements(TargetScope targetScope, TargetType targetType)
        {
            TargetType = targetType;
            TargetScope = targetScope;
        }
        public TargetRequirements(TargetScope targetScope, TargetType targetType, ITargetCardRequirements targetCardRequirements) : this(targetScope, targetType)
        {
            TargetCardRequirements = targetCardRequirements;
        }
        #endregion
    }
}
