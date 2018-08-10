using MTG.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTG.DTO.Responses
{
    public class ActivateCardResponse
    {
        public List<IActivatedAbility> Abilities { get; set; }
    }
}
