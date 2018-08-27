using MTG.Enumerations;
using System;

namespace MTG.Interfaces.Mana_Interfaces
{
    public interface IMana
    {
        Color Color { get; }
        int Count { get;  }
        Guid Id { get; }
        ManaRestriction ManaRestriction { get; }
        SubType ManaRestrictionSubType { get; }
        CardType ManaRestrictionSpellType { get;  }
        bool XCount { get; }
    }
}
