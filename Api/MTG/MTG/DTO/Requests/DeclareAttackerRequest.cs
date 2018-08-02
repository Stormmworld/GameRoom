using MTG.Model.Objects;
using System;

namespace MTG.DTO.Requests
{
    public class DeclareAttackerRequest
    {
        public Card Attacker { get; set; }
        public Guid JoinBandId { get; set; }
    }
}
