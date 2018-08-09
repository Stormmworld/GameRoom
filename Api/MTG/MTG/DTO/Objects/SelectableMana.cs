using MTG.Enumerations;
using System;

namespace MTG.DTO.Objects
{
    public class SelectableMana
    {
        public Guid Id { get; set; }
        public Colors Color { get; set; }
        public int Amount { get; set; }
    }
}
