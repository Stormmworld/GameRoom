using MTG.Enumerations;
using MTG.Interfaces.Card_Interfaces;
using System;
using System.Collections.Generic;

namespace MTG.Interfaces.Data_Interfaces
{
    public interface IDamage
    {
        #region Properties
        Guid Id { get; }
        int Modifier { get; }
        int Value { get; }
        bool UseXValue { get; }
        Modifier XModifier { get; }
        #endregion

        #region Collection Properties
        IReadOnlyList<CardType> CardTypes { get; }
        IReadOnlyList<Color> Colors { get; }
        IReadOnlyList<SubType> SubTypes { get; }
        IReadOnlyList<SuperType> SuperTypes { get; }
        #endregion

        #region Methods
        void Add(CardType cardType);
        void Add(Color color);
        void Add(int Modifier);
        void Add(SubType subType);
        void Add(SuperType superType);
        void Assign(ICard card);
        void Has(CardType cardType);
        void Has(Color color);
        void Has(SubType subType);
        void Has(SuperType superType);
        void Remove(CardType cardType);
        void Remove(Color color);
        void Remove(SubType subType);
        void Remove(SuperType superType);
        #endregion
    }
}
