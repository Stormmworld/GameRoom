using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Interfaces;
using MTGModel.Objects;
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
        public Graveyard()
        {
            _Cards = new List<Card>();
        }
        #endregion

        #region Methods
        public void Add(Card card)
        {
            throw new NotImplementedException("Graveyard.Add");
        }
        public void Add(List<Card> cards)
        {
            throw new NotImplementedException("Graveyard.Add");
        }
        public List<Card> CardsWithAbility(Type abilityType)
        {
            throw new NotImplementedException("Graveyard.CardsWithAbility");
        }
        public List<Card> FilteredCards(Predicate<Card> predicate)
        {
            throw new NotImplementedException("Graveyard.FilteredCards");
        }
        public void ProcessTriggeredAbilities(EffectTrigger trigger, TappingTriggerArgs args)
        {
            foreach (Card card in _Cards.FindAll(o => o.Abilities.FirstOrDefault(a => a.Trigger == trigger) != null))
            {
                foreach (IAbility ability in card.Abilities.FindAll(o => o.Trigger == trigger))
                    ability.Process(new AbilityArgs() { OriginCard = card });
            }
        }
        public void Remove(TargetZone targetZone)
        {//send all cards to targetZone
            throw new NotImplementedException("Graveyard.Remove");
        }
        public void Remove(Card card, TargetZone targetZone)
        {
            throw new NotImplementedException("Graveyard.Remove");
        }

        #endregion
    }
}
