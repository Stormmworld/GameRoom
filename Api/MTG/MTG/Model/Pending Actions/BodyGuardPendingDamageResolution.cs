using MTG.Interfaces;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;

namespace MTG.Model.Pending_Actions
{
    public class BodyGuardPendingDamageResolution : IPendingAction, IPendingDamageResolution
    {
        #region Properties
        public Guid ActionPlayerId { get; set; }
        public List<Card> BodyGuards { get; set; }
        public int Damage { get; set; }
        public Guid Id { get; private set; }
        public Card OriginCard { get; set; }
        #endregion

        #region Constructors
        public BodyGuardPendingDamageResolution()
        {
            Id = Guid.NewGuid();
            BodyGuards = new List<Card>();
        }
        #endregion
    }
}
