﻿using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model.Zones
{
    /*
     *  https://mtg.gamepedia.com/Battlefield
        403.1. Most of the area between the players represents the battlefield. The battlefield starts out empty. Permanents a player 
                controls are normally kept in front of them on the battlefield, though there are some cases (such as an Aura attached 
                to another player’s permanent) when a permanent one player controls is kept closer to a different player.
        403.2. A spell or ability affects and checks only the battlefield unless it specifically mentions a player or another zone.
        403.3. Permanents exist only on the battlefield. Every object on the battlefield is a permanent. See rule 110, “Permanents.”
        403.4. Whenever a permanent enters the battlefield, it becomes a new object and has no relationship to any previous permanent 
                represented by the same card, except for the cases listed in rule 400.7. (This is also true for any objects entering 
                any zone.)
        403.5. Previously, the battlefield was called the “in-play zone.” Cards that were printed with text that contains the phrases 
                “in play,” “from play,” “into play,” or the like are referring to the battlefield. Cards that were printed with that 
                text have received errata in the Oracle card reference.     */
    public class Battlefield: IZone
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
        public Battlefield()
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
            return _Cards.FindAll(predicate);
        }
        public Card Find(Guid cardId)
        {
            return _Cards.FirstOrDefault(o=>o.Id == cardId);
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
        public void Untap()
        {
            foreach (Card card in _Cards)
                if(card.Tapped)
                    card.Tapped = false;
        }
        #endregion
    }
}
