using MTG.Enumerations;
using MTG.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTG.Model.Pending_Actions
{
    public class MulliganPendingAction : IPendingAction
    {
        #region Properties
        public Guid ActionPlayerId { get; set; }
        public Guid Id { get; private set; }
        #endregion

        #region Constructors
        public MulliganPendingAction()
        {
            Id = Guid.NewGuid();
        }
        #endregion
    }
}
