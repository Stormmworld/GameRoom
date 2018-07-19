using MTGModel.Objects;
using System.Collections.Generic;

namespace MTG.Model.Objects
{
    public class StackEntry
    {
        #region Properties
        public int Id { get; set; }
        public Card Card { get; set; }
        public List<Effect> Effects { get; set; }
        public string ImageUrl { get; set; }
        #endregion
    }
}
