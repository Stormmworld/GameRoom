using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Helpers;
using MTG.Interfaces;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model.Zones
{
    /*
     *  https://mtg.gamepedia.com/Library
            401.1. When a game begins, each player’s deck becomes their library.
            401.2. Each library must be kept in a single face-down pile. Players can’t look at or change 
                    the order of cards in a library.
            401.3. Any player may count the number of cards remaining in any player’s library at any time.
            401.4. If an effect puts two or more cards in a specific position in a library at the same 
                    time, the owner of those cards may arrange them in any order. That library’s owner 
                    doesn’t reveal the order in which the cards go into the library.
            401.5. Some effects tell a player to play with the top card of their library revealed, or 
                    say that a player may look at the top card of their library. If the top card of the 
                    player’s library changes while a spell is being cast, the new top card won’t be 
                    revealed and can’t be looked at until the spell becomes cast (see rule 601.2i). The 
                    same is true with relation to an ability being activated.
            401.6. If an effect causes a player to play with the top card of their library revealed, 
                    and that particular card stops being revealed for any length of time before being 
                    revealed again, it becomes a new object.
            401.7. If an effect causes a player to put a card into a library “Nth from the top,” and 
                    that library has fewer than N cards in it, the player puts that card on the bottom 
                    of that library.
     */
    public class Library: IZone
    {
        #region Events
        public event EventHandler OnAddCardToZone, OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
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
        private Guid OwnerId { get; set; }
        public bool ShowTopCard { get; set; }
        #endregion

        #region Constructors
        public Library(Guid ownerId)
        {
            OwnerId = ownerId;
            _Cards = new List<Card>();
            ShowTopCard = false;
        }
        #endregion

        #region Event Handlers
        private void Card_OnCardPhasedIn(object sender, EventArgs e)
        {
            throw new NotImplementedException("Library.Card_OnCardPhasedIn");
        }
        private void Card_OnCardPhasedOut(object sender, EventArgs e)
        {
            throw new NotImplementedException("Library.Card_OnCardPhasedOut");
        }
        private void Card_OnCardTapped(object sender, EventArgs e)
        {
            throw new NotImplementedException("Library.Card_OnCardTapped");
        }
        private void Card_OnCardUntapped(object sender, EventArgs e)
        {
            throw new NotImplementedException("Library.Card_OnCardUntapped");
        }
        private void Card_OnEffectTrigger(object sender, EventArgs e)
        {
            OnEffectTrigger?.Invoke(sender, e);
        }
        private void Card_OnEffectTriggered(object sender, EventArgs e)
        {
            OnEffectTriggered?.Invoke(sender, e);
        }
        private void Card_OnCardDestroyed(object sender, EventArgs e)
        {
            throw new NotImplementedException("Library.Card_OnCardDestroyed");
        }
        private void Card_OnPendingActionTriggered(object sender, EventArgs e)
        {
            OnPendingActionTriggered?.Invoke(sender, e);
        }
        #endregion

        #region Methods
        public void Add(Card card)
        {
            card.OnCardDestroyed += Card_OnCardDestroyed;
            card.OnCardPhasedIn += Card_OnCardPhasedIn;
            card.OnCardPhasedOut += Card_OnCardPhasedOut;
            card.OnCardTapped += Card_OnCardTapped;
            card.OnCardUntapped += Card_OnCardUntapped;
            card.OnEffectTrigger += Card_OnEffectTrigger;
            card.OnEffectTriggered += Card_OnEffectTriggered;
            card.OnPendingActionTriggered += Card_OnPendingActionTriggered;
            card.OwnerId = OwnerId;
            _Cards.Add(card);
        }
        public void Add(List<Card> cards)
        {
            foreach (Card card in cards)
                Add(card);
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
            return _Cards.FindAll(o => o.HasAbility(abilityType));
        }
        public List<Card> Draw(int drawCount, Guid controllingPlayerId)
        {
            List<Card> drawnCards = new List<Card>();
            for (int i = 0; i < drawCount; i++)
            {
                _Cards[0].ControllerId = controllingPlayerId;
                drawnCards.Add(_Cards[0]);
               Remove(_Cards[0].Id);
            }
            return drawnCards;
        }
        public List<Card> FilteredCards(Predicate<Card> predicate)
        {
            return _Cards.FindAll(predicate);
        }
        public Card Find(Guid cardId)
        {
            return _Cards.FirstOrDefault(o => o.Id == cardId);
        }
        public void Insert(Card card, InsertLocation insertLocation)
        {
            switch (insertLocation)
            {
                case InsertLocation.Bottom:
                    _Cards.Add(card);
                    break;
                case InsertLocation.Top:
                    _Cards.Insert(0, card);
                    break;
            }
        }
        public void ProcessTriggeredAbilities(EffectTrigger trigger, ITriggeredAbilityArgs args)
        {
            foreach (Card card in _Cards.FindAll(o => o.Abilities.FirstOrDefault(a => a is ITriggeredAbility && ((ITriggeredAbility)a).Trigger == trigger) != null))
                card.CheckTriggeredAbilities(trigger, args);
        }
        public void Remove(Guid cardId)
        {
            Card cardToRemove = _Cards.FirstOrDefault(o => o.Id == cardId);
            if (cardToRemove != null)
            {
                cardToRemove.OnCardDestroyed -= Card_OnCardDestroyed;
                cardToRemove.OnCardPhasedIn -= Card_OnCardPhasedIn;
                cardToRemove.OnCardPhasedOut -= Card_OnCardPhasedOut;
                cardToRemove.OnCardTapped -= Card_OnCardTapped;
                cardToRemove.OnCardUntapped -= Card_OnCardUntapped;
                cardToRemove.OnEffectTrigger -= Card_OnEffectTrigger;
                cardToRemove.OnEffectTriggered -= Card_OnEffectTriggered;
                cardToRemove.OnPendingActionTriggered -= Card_OnPendingActionTriggered;
                _Cards.Remove(cardToRemove);
            }
        }
        public void Shuffle(int riffleShuffleCount = 3)
        {
            _Cards = CardHelper.ShuffleCards(_Cards, riffleShuffleCount);
        }
        #endregion
    }
}
