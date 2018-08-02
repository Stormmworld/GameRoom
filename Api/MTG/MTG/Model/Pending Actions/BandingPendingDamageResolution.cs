using MTG.Interfaces;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;

namespace MTG.Model.Pending_Actions
{
    public class BandingDamageResolution : IPendingAction, IPendingDamageResolution
    {
        #region Properties
        public Guid ActionPlayerId { get; set; }
        public int Damage { get; set; }
        public List<Card> CardsToDamage { get; set; }
        public Card OriginCard { get; set; }
        #endregion

        #region Constructors
        public BandingDamageResolution()
        {
            CardsToDamage = new List<Card>();
        }
        #endregion
    }
}
