using MTG.Enumerations;
using System;

namespace MTG.Model.Objects
{
    public class AttackableTarget
    {
        #region Properties
        public AttackableType AttackableType { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region Methods
        public Target GenerateTarget()
        {
            return new Target()
            {
                Type = AttackableType == Enumerations.AttackableType.Planeswalker ? Enumerations.TargetType.Planeswalker : Enumerations.TargetType.Player,
                Id = Id,
            };
        }
        #endregion
    }
}
