using MTG.Interfaces.Data_Interfaces;
using System;

namespace MTG.Model.Counters._Base
{
    public class Counter : ICounter
    {
        #region Properties
        public Guid Id { get; private set; }
        public Guid OwningCardId { get; private set; }
        public Guid ControllingPlayerId { get; private set; }
        #endregion

        #region Constructors
        internal Counter()
        {
            Id = Guid.NewGuid();
        }
        #endregion

        #region Methods
        public void Assign(Guid owningCardId, Guid controllingPlayerId)
        {
            OwningCardId = owningCardId;
            ControllingPlayerId= controllingPlayerId;
        }
        public override string ToString()
        {
            return GetType().Name;
        }
        #endregion
    }
}
