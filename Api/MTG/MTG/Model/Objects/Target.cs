using MTG.Enumerations;
using MTGModel.Objects;

namespace MTG.Model.Objects
{
    public class Target
    {
        #region Properties
        public TargetType Type { get; set; }
        public Card Card { get; set; }
        public Player Player { get; set; }
        #endregion
    }
}
