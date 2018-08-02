using System.Collections.Generic;

namespace MTG.DTO.Objects
{
    public class Blocker
    {
        public List<Card> Blockers { get; set; }
        public List<Band> BlockingBands { get; set; }
    }
}
