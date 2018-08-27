using System;
using MTG.Enumerations;
using MTG.Interfaces.Mana_Interfaces;

namespace MTG.Model.Mana_Objects
{
    public class Mana : IMana
    {
        #region Properties
        public Color Color { get; private set; }
        public int Count { get; private set; }
        public Guid Id { get; private set; }
        public ManaRestriction ManaRestriction { get; private set; }
        public SubType ManaRestrictionSubType { get; private set; }
        public CardType ManaRestrictionSpellType { get; private set; }
        public bool XCount { get; private set; }
        #endregion

        #region Constructors
        public Mana(Color color, int count)
        {
            Color = color;
            Count = count;
        }
        public Mana(Color color, bool xCount)
        {
            Color = color;
            XCount = xCount;
        }
        #endregion
    }
}
