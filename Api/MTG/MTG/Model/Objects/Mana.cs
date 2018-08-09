using MTG.Enumerations;
using System;

namespace MTG.Model.Objects
{
    public class Mana
    {
        #region Constructors
        public Colors Color { get; set; }
        public int Count { get; set; }
        public Guid Id { get; private set; }
        public ManaRestriction ManaRestriction  { get;set; }
        public SubType ManaRestrictionSubType { get; set; }
        public CardType ManaRestrictionSpellType { get; set; }
        #endregion

        #region Constructors
        public Mana()
        {
            Id = Guid.NewGuid();
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

        #region Operators
        public static bool operator ==(Mana x, Mana y)
        {
            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
                return ReferenceEquals(y, null) && ReferenceEquals(x, null);
            return x.Equals(y);
        }
        public static bool operator !=(Mana x, Mana y)
        {
            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
                return ReferenceEquals(y, null) && ReferenceEquals(x, null);
            return !(x == y);
        }
        #endregion

        #region Methods
        public override bool Equals(object obj)
        {
            if (!(obj is Card)) return false;
            return Id == ((Card)obj).Id;
        }
        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
        #endregion
    }
}
