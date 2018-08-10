using MTG.Interfaces;
using System;

namespace MTG.Templates
{
    public class PendingActionTemplate: IPendingAction
    {
        #region Properties
        public Guid ActionPlayerId { get; set; }
        public Guid Id { get; private set; }
        #endregion

        #region Constructors
        public PendingActionTemplate()
        {
            Id = Guid.NewGuid();
        }
        #endregion
    }
}
