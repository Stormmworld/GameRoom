using MTG.Interfaces;
using MTGModel.Objects;
using System.Collections.Generic;

namespace MTG.Model.Pending_Actions
{
    public class PendingDamageResolution : IPendingAction
    {
        #region Properties
        public int ActionPlayerId { get; set; }
        public int Damage { get; set; }
        public List<Card> CardsToDamage { get; set; }
        #endregion

        #region Constructors
        public PendingDamageResolution()
        {
            CardsToDamage = new List<Card>();
        }
        #endregion
    }
}
