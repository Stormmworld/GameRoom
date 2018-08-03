using MTG.Enumerations;

namespace MTG.Model.Objects
{
    public class Mana
    {
        #region Constructors
        public Colors Color { get; set; }
        public int Count { get; set; }
        public ManaRestriction ManaRestriction  { get;set; }
        public SubType ManaRestrictionSubType { get; set; }
        public CardType ManaRestrictionSpellType { get; set; }
        #endregion

        #region Constructors
        public Mana()
        {
        }
        public Mana(Mana mana)
        {
            Color = mana.Color;
            Count = mana.Count;
            ManaRestriction = mana.ManaRestriction;
            ManaRestrictionSubType = mana.ManaRestrictionSubType;
            ManaRestrictionSpellType = mana.ManaRestrictionSpellType;
        }
        #endregion
    }
}
