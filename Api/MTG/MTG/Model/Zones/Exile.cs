using MTG.Enumerations;
using MTG.Interfaces;
using MTG.ArgumentDefintions;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model.Zones
{
    /*
     *  https://mtg.gamepedia.com/Exile
        406.1. The exile zone is essentially a holding area for objects. Some spells and abilities exile an object 
                without any way to return that object to another zone. Other spells and abilities exile an object 
                only temporarily.
        406.2. To exile an object is to put it into the exile zone from whatever zone it’s currently in. An exiled 
                card is a card that’s been put into the exile zone.
        406.3. Exiled cards are, by default, kept face up and may be examined by any player at any time. Cards 
                “exiled face down” can’t be examined by any player except when instructions allow it. However, once
                a player is allowed to look at a card exiled face down, that player may continue to look at that card 
                as long as it remains exiled, even if the instruction allowing the player to do so no longer applies. 
                A card exiled face down has no characteristics, but the spell or ability that exiled it may allow it 
                to be played from exile. Unless that card is being cast face down (see rule 707.4), the card is turned 
                face up just before the player announces that they are playing the card (see rule 601.2).
        406.4. Face-down cards in exile should be kept in separate piles based on when they were exiled and how they 
                were exiled. If a player is instructed to choose an exiled card, the player may choose a specific 
                face-down card only if the player is allowed to look at that card. Otherwise, they may choose a pile
                of face-down exiled cards, and then a card is chosen at random from within that pile. If choosing such 
                a card is part of casting a spell or activating an ability, the chosen card isn’t revealed until after 
                that cost is fully paid. (See rule 601.2i.)
        406.5. Exiled cards that might return to the battlefield or any other zone should be kept in separate piles 
                to keep track of their respective ways of returning. Exiled cards that may have an impact on the game 
                due to their own abilities (such as cards with haunt) or the abilities of the cards that exiled them 
                should likewise be kept in separate piles.
        406.6. An object may have one ability printed on it that causes one or more cards to be exiled, and another 
                ability that refers either to “the exiled cards” or to cards “exiled with [this object].” These 
                abilities are linked: the second refers only to cards that have been exiled due to the first. See 
                rule 607, “Linked Abilities.”
        406.7. If an object in the exile zone becomes exiled, it doesn’t change zones, but it becomes a new object 
                that has just been exiled.
        406.8. Previously, the exile zone was called the “removed-from-the-game zone.” Cards that were printed with 
                text that “removes [an object] from the game” exiles that object. The same is true for cards printed 
                with text that “sets [an object] aside.” Cards that were printed with that text have received errata 
                in the Oracle card reference.
     */
    public class Exile: IZone
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
        public Exile()
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
