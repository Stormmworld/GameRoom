using MTG.ArgumentDefintions.Event_Arguments;
using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model.Zones
{
    /*
     *  https://mtg.gamepedia.com/Graveyard
        404.1. A player’s graveyard is their discard pile. Any object that’s countered, discarded, destroyed, 
                or sacrificed is put on top of its owner’s graveyard, as is any instant or sorcery spell 
                that’s finished resolving. Each player’s graveyard starts out empty.
        404.2. Each graveyard is kept in a single face-up pile. A player can examine the cards in any 
                graveyard at any time but normally can’t change their order. Additional rules applying to 
                sanctioned tournaments may allow a player to change the order of cards in their graveyard.
        404.3. If an effect or rule puts two or more cards into the same graveyard at the same time, the 
                owner of those cards may arrange them in any order.
     */
    public class Graveyard: IZone
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
        #endregion

        #region Constructors
        public Graveyard()
        {
            _Cards = new List<Card>();
        }
        #endregion

        #region Event Handlers
        private void Card_OnCardPhasedIn(object sender, EventArgs e)
        {
            throw new NotImplementedException("ZoneTemplate.Card_OnCardPhasedIn");
        }
        private void Card_OnCardPhasedOut(object sender, EventArgs e)
        {
            throw new NotImplementedException("ZoneTemplate.Card_OnCardPhasedOut");
        }
        private void Card_OnCardTapped(object sender, EventArgs e)
        {
            throw new NotImplementedException("ZoneTemplate.Card_OnCardTapped");
        }
        private void Card_OnCardUntapped(object sender, EventArgs e)
        {
            throw new NotImplementedException("ZoneTemplate.Card_OnCardUntapped");
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
            throw new NotImplementedException("ZoneTemplate.Card_OnCardDestroyed");
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
        public List<Card> FilteredCards(Predicate<Card> predicate)
        {
            return _Cards.FindAll(predicate);
        }
        public Card Find(Guid cardId)
        {
            return _Cards.FirstOrDefault(o => o.Id == cardId);
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
        #endregion
    }
}
