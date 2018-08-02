using System;
using System.Collections.Generic;

namespace MTGModel.Objects
{
    public class CastingCost
    {
        public List<ManaCost> manaCosts { get; set; }
        public int XCost { get; set; }
    }
}
