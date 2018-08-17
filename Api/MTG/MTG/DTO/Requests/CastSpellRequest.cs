using MTG.DTO.Objects;
using System;
using System.Collections.Generic;

namespace MTG.DTO.Requests
{
    public class CastSpellRequest
    {
        public Guid SpellId { get; set; }
        public Guid PlayerId { get; set; }
        public List<SelectableAbility> Abilities { get; set; }
    }
}
