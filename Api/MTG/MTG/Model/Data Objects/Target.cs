using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using System;

namespace MTG.Model.Data_Objects
{
    public class Target: ITarget
    {
        #region Properties
        public Guid Id { get; private set; }
        public TargetType Type { get; private set; }
        #endregion

        #region Constructors
        public Target()
        {
            Id = new Guid();
            Type = TargetType.None;
        }
        public Target(TargetType targetType, Guid targetId)
        {
            Id = targetId;
            Type = targetType;
        }
        #endregion
    }
}
