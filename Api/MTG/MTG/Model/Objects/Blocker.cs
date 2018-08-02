using MTG.Model.Objects;
using System.Collections.Generic;

namespace MTG.Model.Objects
{
    public class Blocker
    {
        public List<Card> Blockers { get; set; }
        public List<Band> BlockingBands { get; set; }
    }
}
