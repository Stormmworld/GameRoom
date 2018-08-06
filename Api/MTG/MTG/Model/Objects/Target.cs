using MTG.Enumerations;
using System;

namespace MTG.Model.Objects
{
    public class Target
    {
        #region Properties
        public TargetType Type { get; set; }
        public Guid Id { get; set; }
        #endregion
    }
}
