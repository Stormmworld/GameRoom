using System;
using System.Collections.Generic;

namespace MTG.Model.Objects
{
    public class CastingCost
    {
        #region Properties
        public List<ManaCost> ManaCosts { get; set; }
        public int XCost { get; set; }
        #endregion

        #region Constructors
        public CastingCost()
        {
            ManaCosts = new List<ManaCost>();
        }
        #endregion
    }
}
