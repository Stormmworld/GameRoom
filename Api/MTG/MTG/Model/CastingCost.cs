using System;
using System.Collections.Generic;
using System.Text;

namespace MTG.Model
{
    class CastingCost
    {
        public List<ManaCost> manaCosts { get; set; }
        public int XCost { get; set; }
    }
}
