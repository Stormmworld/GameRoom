using System;
using System.Collections.Generic;

namespace MTGModel.Objects
{
    class CastingCost
    {
        public List<ManaCost> manaCosts { get; set; }
        public int XCost { get; set; }
    }
}
