using MTG.Enumerations;
using MTG.Interfaces.Argument_Interfaces;
using MTG.Interfaces.Effect_Interfaces;
using MTG.Interfaces.Mana_Interfaces;
using System;
using System.Collections.Generic;

namespace MTG.Interfaces.Card_Interfaces
{
    public interface ICard
    {
        #region Events
        event EventHandler OnCardEvent, OnNewEffect, OnEvent;
        #endregion

        #region Collection Properties
        IReadOnlyList<CardType> CardTypes { get; }
        IReadOnlyList<Color> Colors { get; }
        IReadOnlyList<IEffect> Effects { get; }
        IReadOnlyList<SubType> SubTypes { get; }
        IReadOnlyList<SuperType> SuperTypes { get; }
        #endregion

        #region Properties
        ICastingCost CastingCost { get; }
        Guid Id { get; }
        string ImageUrl { get; }
        int MultiverseId { get; }
        string Name { get; }
        Guid OwnerId { get; set; }
        #endregion

        #region Event Handlers
        void Ability_NewEffect(object sender, EventArgs e);
        void Ability_Event(object sender, EventArgs e);
        #endregion

        #region Methods
        void Add(CardType cardType);
        void Add(Color color);
        void Add(IEffect effect);
        void Add(SubType subType);
        void Add(SuperType superType);
        void Apply(ICardArguments args);
        void Apply(EffectTrigger trigger, ITriggeredAbilityArguments args);
        bool Has(CardType cardType);
        bool Has(Color color);
        bool Has(IEffect effect);
        bool Has(SubType subType);
        bool Has(SuperType superType);
        void Remove(CardType cardType);
        void Remove(Color color);
        void Remove(IEffect effect);
        void Remove(SubType subType);
        void Remove(SuperType superType);
        #endregion
    }
}
