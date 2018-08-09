using MTG.Enumerations;
using MTG.Interfaces;
using System;

namespace MTG.DTO.Requests.CompleteActions
{
    public class MulliganCompleteActionRequest : ICompleteActionRequest
    {
        #region Properties
        public Guid ActionId { get; set; }
        public Guid ActionPlayerId { get; set; }
        public bool Reshuffle { get; set; }
        #endregion
    }
}
