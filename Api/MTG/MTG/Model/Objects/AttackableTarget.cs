using MTG.Enumerations;

namespace MTG.Model.Objects
{
    public class AttackableTarget
    {
        #region Properties
        public AttackableType AttackableType { get; set; }
        public int PlaneswalkerId { get; set; }
        public int PlayerId { get; set; }
        public string Name { get; set; }
        #endregion
    }
}
