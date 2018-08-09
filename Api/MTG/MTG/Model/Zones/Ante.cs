﻿using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;
using MTG.ArgumentDefintions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model.Zones
{
    /*
     *  https://mtg.gamepedia.com/Ante
        407.1. Earlier versions of the Magic rules included an ante rule as a way of playing “for keeps.” Playing Magic games 
                for ante is now considered an optional variation on the game, and it’s allowed only where it’s not forbidden 
                by law or by other rules. Playing for ante is strictly forbidden under the Magic: The Gathering Tournament 
                Rules (WPN.Wizards.com/en/resources/rules-documents).
        407.2. When playing for ante, each player puts one random card from their deck into the ante zone after determining 
                which player goes first but before players draw any cards. Cards in the ante zone may be examined by any player 
                at any time. At the end of the game, the winner becomes the owner of all the cards in the ante zone.
        407.3. A few cards have the text “Remove [this card] from your deck before playing if you’re not playing for ante.” 
                These are the only cards that can add or remove cards from the ante zone or change a card’s owner. When not 
                playing for ante, players can’t include these cards in their decks or sideboards, and these cards can’t be 
                brought into the game from outside the game.
        407.4. To ante an object is to put that object into the ante zone from whichever zone it’s currently in. The owner of 
                an object is the only person who can ante that object.
     */
    public class Ante: IZone
    {
        #region Events
        public event EventHandler OnEffectTrigger;
        #endregion

        #region Variables
        private List<Card> _Cards;
        #endregion

        #region Properties
        public IReadOnlyCollection<Card> Cards
        {
            get
            {
                return _Cards.AsReadOnly();
            }
        }
        #endregion

        #region Constructors
        public Ante()
        {
            _Cards = new List<Card>();
        }
        #endregion

        #region Methods
        public void Add(Card card)
        {
            throw new NotImplementedException("Ante.Add");
        }
        public void Add(List<Card> cards)
        {
            throw new NotImplementedException("Ante.Add");
        }
        public void Add(IEffect effect)
        {
            foreach (Card card in _Cards)
            {
                if (card.Id == effect.Target.Id)
                {
                    card.Add(effect);
                    break;
                }
            }
        }
        public List<Card> CardsWithAbility(Type abilityType)
        {
            throw new NotImplementedException("Ante.CardsWithAbility");
        }
        public List<Card> FilteredCards(Predicate<Card> predicate)
        {
            throw new NotImplementedException("Ante.FilteredCards");
        }
        public Card Find(Guid cardId)
        {
            return _Cards.FirstOrDefault(o => o.Id == cardId);
        }
        public void ProcessTriggeredAbilities(EffectTrigger trigger, AbilityArgs args)
        {
            foreach (Card card in _Cards.FindAll(o => o.Abilities.FirstOrDefault(a => a.Trigger == trigger) != null))
                card.CheckTriggeredAbilities(trigger, args);
        }
        public void Remove(Guid cardId)
        {
            Card cardToRemove = _Cards.FirstOrDefault(o => o.Id == cardId);
            if (cardToRemove != null)
                _Cards.Remove(cardToRemove);
        }
        #endregion
    }
}
