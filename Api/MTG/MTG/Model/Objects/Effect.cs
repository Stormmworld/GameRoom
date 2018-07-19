using MTG.Enumerations;
using MTGModel.Objects;

namespace MTG.Model.Objects
{
    public class Effect
    {
        #region Properties
        public TargetType TargetType { get; set; }
        public TargetScope TargetScope { get; set; }
        public Player TargetPlayer { get; set; }
        public Card TargetCard { get; set; }
        public int Value { get; set; }
        #endregion
    }
}
