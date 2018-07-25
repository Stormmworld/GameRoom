using MTG.Interfaces;
using MTGModel.Objects;
using System.Collections.Generic;

namespace MTG.Model.Pending_Actions
{
    public class BodyGuardPendingDamageResolution : IPendingAction, IPendingDamageResolution
    {
        #region Properties
        public int ActionPlayerId { get; set; }
        public int Damage { get; set; }
        public List<Card> BodyGuards { get; set; }
        public Card OriginCard { get; set; }
        #endregion

        #region Constructors
        public BodyGuardPendingDamageResolution()
        {
            BodyGuards = new List<Card>();
        }
        #endregion
    }
}
