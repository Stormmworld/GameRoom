using System;

namespace MTG.DTO.Objects
{
    public class Card
    {
        public Guid Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public bool PhasedOut { get; set; }
        public int Power { get; set; }
        public bool Tapped { get; set; }
        public int Toughness { get; set; }
    }
}
