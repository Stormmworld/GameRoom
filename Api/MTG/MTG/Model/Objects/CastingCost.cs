using System;
using System.Collections.Generic;

namespace MTG.Model.Objects
{
    public class CastingCost
    {
        public List<ManaCost> manaCosts { get; set; }
        public int XCost { get; set; }
    }
}
