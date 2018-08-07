using MTG.Model.Objects;
using System;

namespace MTG.DTO.Requests
{
    public class DeclareBlockerRequest
    {
        public Guid AttackerId { get; set; }
        public Guid BlockerId { get; set; }
        public Guid JoinBandId { get; set; }
    }
}
