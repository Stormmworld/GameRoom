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
        public bool ShowTopCard { get; set; }
        #endregion

        #region Constructors
        public Library()
        {
            _Cards = new List<Card>();
            ShowTopCard = false;
        }
        #endregion

        #region Methods
        public void Add(Card card)
        {
            throw new NotImplementedException("Library.Add");
        }
        public void Add(List<Card> cards)
        {
            _Cards.AddRange(cards);
        }
        public List<Card> CardsWithAbility(Type abilityType)
        {
            throw new NotImplementedException("Library.CardsWithAbility");
        }
        public List<Card> Draw(int drawCount)
        {
            List<Card> drawnCards = new List<Card>();
            for (int i = 0; i < drawCount; i++)
            {
                drawnCards.Add(_Cards[0]);
                _Cards.RemoveAt(0);
            }
            return drawnCards;
        }
        public List<Card> FilteredCards(Predicate<Card> predicate)
        {
            throw new NotImplementedException("Library.FilteredCards");
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
        public void ProcessTriggeredAbilities(EffectTrigger trigger, ITriggerArgs args)
        {
            throw new NotImplementedException("Library.ProcessTriggeredAbilities");
        }
        public void Remove(Card card, TargetZone targetZone)
        {
            throw new NotImplementedException("Library.Remove");
        }
        public void Shuffle(int riffleShuffleCount = 3)
        {
            _Cards = CardHelper.ShuffleCards(_Cards, riffleShuffleCount);
        }
        #endregion
    }
}
