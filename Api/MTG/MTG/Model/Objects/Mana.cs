using MTG.Enumerations;

namespace MTG.Model.Objects
{
    public class Mana
    {
        public int Count { get; set; }
        public Colors Color { get; set; }
        public ManaRestriction ManaRestriction  { get;set; }
        public SubType ManaRestrictionSubType { get; set; }
        public CardType ManaRestrictionSpellType { get; set; }
    }
}
