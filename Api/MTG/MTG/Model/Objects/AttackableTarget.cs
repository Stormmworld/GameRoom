using MTG.Enumerations;
using System;

namespace MTG.Model.Objects
{
    public class AttackableTarget
    {
        #region Properties
        public AttackableType AttackableType { get; set; }
        public Guid PlaneswalkerId { get; set; }
        public Guid PlayerId { get; set; }
        public string Name { get; set; }
        #endregion
    }
}
