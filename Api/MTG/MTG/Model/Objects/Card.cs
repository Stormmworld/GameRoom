using MTG.Enumerations;
using MTG.Interfaces;
using System.Collections.Generic;

namespace MTGModel.Objects
{
    public class Card
    {
        #region Properties
        public List<IAbility> Abilities { get; set; } 
        public List<CardType> CardTypes { get; set; }
        #endregion

        #region Constructors
        public Card()
        {
            Abilities = new List<IAbility>();
            CardTypes = new List<CardType>();
        }
        public Card(Card card):this()
        {
            for (int i = 0; i < card.Abilities.Count; i++)
                Abilities.Add(card.Abilities[i]);
            for (int i = 0; i < card.CardTypes.Count; i++)
                CardTypes.Add(card.CardTypes[i]);
        }
        #endregion

        #region Methods
        #endregion
    }
}
