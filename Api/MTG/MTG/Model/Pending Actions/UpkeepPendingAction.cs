using System;
using MTG.Interfaces;
using MTG.Model.Objects;

namespace MTG.Model.Pending_Actions
{
    public class UpkeepPendingAction : EventArgs, IPendingAction
    {
        #region Properties
        public UpkeepAction Action { get; set; }
        public Guid ActionPlayerId { get; set; }
        public Guid CardId { get; set; }
        public Guid UpkeepId { get; set; }
        #endregion
    }
}
