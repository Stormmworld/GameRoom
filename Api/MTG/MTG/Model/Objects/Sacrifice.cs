using MTG.Enumerations;

namespace MTG.Model.Objects
{
    public class Sacrifice
    {
        #region Properties
        public SacrificeType Type { get; set; }
        public CardType CardType { get; set; }
        public int Count { get; set; }
        #endregion
    }
}
