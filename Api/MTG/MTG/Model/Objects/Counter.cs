using MTG.Enumerations;

namespace MTG.Model.Objects
{
    public class Counter
    {
        #region Properties
        public CounterType CounterType { get; set; }
        public int OwningCardId { get; set; }
        public int OwningPlayerId { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

    }
}
