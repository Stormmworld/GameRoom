using MTG.Interfaces;
using System;
using System.Collections.Generic;

namespace MTG.DTO.Responses
{
    public class ActivateCardResponse
    {
        public List<IActivatedAbility> Abilities { get; set; }
        public Guid CardId { get; set; }
    }
}
