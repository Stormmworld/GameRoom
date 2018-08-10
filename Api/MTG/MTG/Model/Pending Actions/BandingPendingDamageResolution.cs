using MTG.Interfaces;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;

namespace MTG.Model.Pending_Actions
{
    public class BandingDamageResolution : IPendingDamageResolution
    {
        #region Properties
        public Guid ActionPlayerId { get; set; }
        public List<Card> CardsToDamage { get; set; }
        public int Damage { get; set; }
        public Guid Id { get; private set; }
        public Card OriginCard { get; set; }
        #endregion

        #region Constructors
        public BandingDamageResolution()
        {
            Id = Guid.NewGuid();
            CardsToDamage = new List<Card>();
        }
        #endregion
    }
}
