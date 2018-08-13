using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Templates
{
    public class ZoneTemplate: IZone
    {
        /*
         * ZoneTemplate
         */

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
        public ZoneTemplate()
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
