using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model.Zones
{
    /*
     *  https://mtg.gamepedia.com/Command
        408.1. The command zone is a game area reserved for certain specialized objects that have an overarching effect on 
                the game, yet are not permanents and cannot be destroyed.
        408.2. Emblems may be created in the command zone. See rule 113, “Emblems.”
        408.3. In the Planechase, Vanguard, Commander, Archenemy, and Conspiracy Draft casual variants, nontraditional 
                Magic cards and/or specially designated cards start the game in the command zone. Each variant has its own 
                rules regarding such cards. See section 9, “Casual Variants.”
     */
    public class Command: IZone
    {
        #region Events
        public event EventHandler OnAddCardToZone, OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnApplyDamage, OnCardEvent;
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
        public Command()
        {
            _Cards = new List<Card>();
        }
        #endregion

        #region Event Handlers
        private void Card_OnCardEvent(object sender, EventArgs e)
        {
            OnCardEvent?.Invoke(sender, e);
        }
        private void Card_OnEffectTrigger(object sender, EventArgs e)
        {
            OnEffectTrigger?.Invoke(sender, e);
        }
        private void Card_OnEffectTriggered(object sender, EventArgs e)
        {
            OnEffectTriggered?.Invoke(sender, e);
        }
        private void Card_OnPendingActionTriggered(object sender, EventArgs e)
        {
            OnPendingActionTriggered?.Invoke(sender, e);
        }
        #endregion

        #region Methods
        public void Add(Card card)
        {
            card.OnCardEvent += Card_OnCardEvent;
            card.OnEffectTrigger += Card_OnEffectTrigger;
            card.OnEffectTriggered += Card_OnEffectTriggered;
            card.OnPendingActionTriggered += Card_OnPendingActionTriggered;
            card.OnApplyDamage += OnApplyDamage;
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
                cardToRemove.OnCardEvent -= Card_OnCardEvent;
                cardToRemove.OnEffectTrigger -= Card_OnEffectTrigger;
                cardToRemove.OnEffectTriggered -= Card_OnEffectTriggered;
                cardToRemove.OnPendingActionTriggered -= Card_OnPendingActionTriggered;
                _Cards.Remove(cardToRemove);
            }
        }
        #endregion
    }
}
