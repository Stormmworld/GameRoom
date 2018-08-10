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
        #endregion

        #region Constructors
        public Graveyard()
        {
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
        public List<Card> FilteredCards(Predicate<Card> predicate)
        {
            throw new NotImplementedException("Graveyard.FilteredCards");
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
                _Cards.Remove(cardToRemove);
        }
        #endregion
    }
}
