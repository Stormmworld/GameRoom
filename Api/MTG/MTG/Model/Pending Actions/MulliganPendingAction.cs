using MTG.Enumerations;
using MTG.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTG.Model.Pending_Actions
{
    public class MulliganPendingAction : IPendingAction
    {
        public Guid ActionPlayerId { get; set; }
    }
}
