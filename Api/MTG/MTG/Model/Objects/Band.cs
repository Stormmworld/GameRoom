using MTG.Enumerations;
using MTG.Model.Objects;
using System.Collections.Generic;

namespace MTG.Model.Objects
{
    public class Band
    {
        #region Variables
        #endregion

        #region Properties
        public BandTypes BandType { get; set; }
        public List<Card> BandMembers { get; set; }
        public Blocker Blocker { get; set; }
        #endregion

        #region Constructors
        public Band()
        {
            Blocker = new Blocker();
            BandMembers = new List<Card>();
        }
        #endregion
    }
}
