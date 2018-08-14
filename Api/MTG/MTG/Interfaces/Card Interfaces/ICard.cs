using MTG.Enumerations;
using System;
using System.Collections.Generic;

namespace MTG.Interfaces.Card_Interfaces
{
    public interface ICard
    {
        #region Events
        event EventHandler OnCardEvent, OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region properties
        string ImageUrl { get; }
        Guid Id { get; }
        string Name { get; set; }
        Guid OwnerId { get; }
        #endregion

        #region collection properties
        IReadOnlyList<IAbility> Abilities { get; }
        IReadOnlyList<Colors> Colors { get; }
        IReadOnlyList<SubType> SubTypes { get; }
        IReadOnlyList<SuperType> SuperTypes { get; }
        IReadOnlyList<CardType> Types { get; }
        #endregion

        #region Event Handlers
        void Ability_OnCardEvent(object sender, EventArgs e);
        void Ability_OnPendingActionTriggered(object sender, EventArgs e);
        void Ability_OnEffectTrigger(object sender, EventArgs e);
        void Ability_OnEffectTriggered(object sender, EventArgs e);
        #endregion

        #region Methods
        void Add(IAbility ability);
        void Add(CardType cardType);
        void Add(Colors color);
        void Add(SubType subType);
        void Add(SuperType superType);
        void Apply(ICardEventArgs args);
        bool Has(IAbility ability);
        bool Has(CardType cardType);
        bool Has(SubType subType);
        bool Has(SuperType superType);
        void Remove(IAbility ability);
        void Remove(CardType cardType);
        void Remove(Colors color);
        void Remove(SubType subType);
        void Remove(SuperType superType);
        string ToString();
        #endregion
    }
}
