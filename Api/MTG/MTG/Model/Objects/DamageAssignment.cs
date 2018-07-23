using MTG.Interfaces;
using MTGModel.Objects;
using System.Collections.Generic;

namespace MTG.Model.Objects
{
    public class DamageAssignment: IPendingActions
    {
        #region Properties
        public int ActionPlayerId { get; set; }
        public int DamageToAssign { get; set; }
        public List<Card> DamageRecipients { get; set; }
        #endregion
    }
}
