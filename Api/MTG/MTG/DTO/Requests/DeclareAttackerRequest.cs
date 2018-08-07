using MTG.Model.Objects;
using System;

namespace MTG.DTO.Requests
{
    public class DeclareAttackerRequest
    {
        public Guid AttackerId { get; set; }
        public Guid JoinBandId { get; set; }
        public AttackableTarget Target { get; set; }
    }
}
