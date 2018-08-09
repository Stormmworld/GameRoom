using MTG.DTO.Objects;
using System;
using System.Collections.Generic;

namespace MTG.DTO.Responses
{
    public class CastSpellResponse
    {
        public Guid SpellId { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
