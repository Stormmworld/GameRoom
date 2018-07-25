using MTG.Enumerations;
using MTG.Interfaces;
using MTGModel.Objects;
using System.Collections.Generic;

namespace MTG.Model.Pending_Actions
{
    public class BandingDamageResolution : IPendingAction, IPendingDamageResolution
    {
        #region Properties
        public int ActionPlayerId { get; set; }
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
