using System;

namespace MTG.DTO.Requests
{
    public class SelectAbilityRequest
    {
        public Guid CardId { get; set; }
        public Guid AbilityId {get;set;}
    }
}
