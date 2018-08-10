﻿using MTG.ArgumentDefintions.Event_Arguments;
using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model.Zones
{
    /*
     *  https://mtg.gamepedia.com/Hand
        402.1. The hand is where a player holds cards that have been drawn. Cards can be put into a player’s 
                hand by other effects as well. At the beginning of the game, each player draws a number of 
                cards equal to that player’s starting hand size, normally seven. 
                (See rule 103, “Starting the Game.”)
        402.2. Each player has a maximum hand size, which is normally seven cards. A player may have any 
                number of cards in their hand, but as part of their cleanup step, the player must discard 
                excess cards down to the maximum hand size.
        402.3. A player may arrange their hand in any convenient fashion and look at it at any time. A player 
                can’t look at the cards in another player’s hand but may count those cards at any time.
     */
    public class Hand: IZone
    {
        #region Events
        public event EventHandler OnEffectTrigger, OnAddCardToZone;
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
        public bool HandRevealed { get; set; }
        public int InitialSize { get; set; }
        public int MaximumSize { get; set; }
        #endregion

        #region Constructors
        public Hand()
        {
            InitialSize = 7;
            MaximumSize = 7;
            _Cards = new List<Card>();
        }
        #endregion

        #region Methods
        public void Add(Card card)
        {
            _Cards.Add(card);
        }
        public void Add(List<Card> cards)
        {
            _Cards.AddRange(cards);
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
        public void Discard(bool random, int cardIndex)
        {
            if (random)
            {
                Random rng = new Random();
                Discard(rng.Next(0, _Cards.Count - 1));
            }
            else
            {

            }

            throw new NotImplementedException("Hand.Discard");
        }
        public void Discard(Card card)
        {
            throw new NotImplementedException("Hand.Discard");
        }
        public void Discard(int cardId)
        {
            throw new NotImplementedException("Hand.Discard");
        }
        public List<Card> FilteredCards(Predicate<Card> predicate)
        {
            return _Cards.FindAll(predicate);
        }
        public Card Find(Guid cardId)
        {
            return _Cards.FirstOrDefault(o => o.Id == cardId);
        }
        public bool LandMulligan()
        {
            var landInHand = _Cards.FindAll(o=>o.CardTypes.Contains(CardType.Land));
            if (landInHand.Count < 2)
                return true;
            else
                return landInHand.Count == MaximumSize;
        }
        public void ProcessTriggeredAbilities(EffectTrigger trigger, ITriggeredAbilityArgs args)
        {
            foreach (Card card in _Cards.FindAll(o => o.Abilities.FirstOrDefault(a => a is ITriggeredAbility && ((ITriggeredAbility)a).Trigger == trigger) != null))
                card.CheckTriggeredAbilities(trigger, args);
        }
        public void Remove(TargetZone targetZone)
        {//send all cards to targetZone
            foreach (Card card in _Cards)
                OnAddCardToZone?.Invoke(this, new AddCardToZoneEventArgs() { Card = card, TargetZone = targetZone, ZoneOwnerId = card.OwnerId });
            _Cards.Clear();
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
