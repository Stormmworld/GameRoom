using System;

namespace MTG.DTO.Requests
{
    public class CastSpellRequest
    {
        public Guid SpellId { get; set; }
        public Guid PlayerId { get; set; }
    }
}
