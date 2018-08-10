using MTG.Interfaces;
using MTG.Model.Objects;
using System;

namespace MTG.Templates
{
    public class PendingDamageResolutionTemplate: IPendingDamageResolution
    {
        #region Properties
        public Guid ActionPlayerId { get; set; }
        public int Damage { get; set; }
        public Guid Id { get; private set; }
        public Card OriginCard { get; set; }
        #endregion

        #region Constructors
        public PendingDamageResolutionTemplate()
        {
            Id = Guid.NewGuid();
        }
        #endregion
    }
}
