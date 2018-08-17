using MTG.Enumerations;
using MTG.Interfaces.Ability_Interfaces;
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
                return !(ReferenceEquals(y, null) && ReferenceEquals(x, null));
            return !(x == y);
        }
        #endregion

        #region Methods
        public bool CanUse(Card spell)
        {
            if (ManaRestriction == ManaRestriction.None)
                return true;
            return CanUse(spell, null);
        }
        public bool CanUse(IAbility ability)
        {
            if (ManaRestriction == ManaRestriction.None)
                return true;
            return CanUse(null, ability);
        }
        private bool CanUse(Card spell = null, IAbility ability = null)
        {           
            if (ManaRestrictionSubType != SubType.None)
                return spell.HasSubType(ManaRestrictionSubType);
            if (ManaRestrictionSpellType != CardType.None)
                return spell.HasType(ManaRestrictionSpellType);
            throw new NotImplementedException("Mana.CanUse");
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Mana)) return false;
            return Id == ((Mana)obj).Id;
        }
        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
        #endregion
    }
}
