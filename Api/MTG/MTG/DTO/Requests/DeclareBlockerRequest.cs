using MTGModel.Objects;
using System;

namespace MTG.DTO.Requests
{
    public class DeclareBlockerRequest
    {
        public Guid AttackerId { get; set; }
        public Guid AttackingBandId { get; set; }
        public Card Blocker { get; set; }
        public Guid JoinBandId { get; set; }
    }
}
