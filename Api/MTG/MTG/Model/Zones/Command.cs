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

        #region Methods
        public void Add(Card card)
        {
            throw new NotImplementedException("Command.Add");
        }
        public void Add(List<Card> cards)
        {
            throw new NotImplementedException("Command.Add");
        }
        public List<Card> CardsWithAbility(Type abilityType)
        {
            throw new NotImplementedException("Command.CardsWithAbility");
        }
        public List<Card> FilteredCards(Predicate<Card> predicate)
        {
            throw new NotImplementedException("Command.FilteredCards");
        }
        public void ProcessTriggeredAbilities(EffectTrigger trigger)
        {
            foreach (Card card in _Cards.FindAll(o => o.Abilities.FirstOrDefault(a => a.Trigger == trigger) != null))
            {
                foreach (IAbility ability in card.Abilities.FindAll(o => o.Trigger == trigger))
                    ability.Process(new AbilityArgs() { OriginCard = card });
            }
        }
        public void Remove(Card card, TargetZone targetZone)
        {
            throw new NotImplementedException("Ante.Remove");
        }
        #endregion
    }
}
