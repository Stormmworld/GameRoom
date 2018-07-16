using MTGModel.Objects;
using System.Collections.Generic;

namespace MTG.Model.Objects
{
    public class Deck
    {
        #region Properties
        public List<Card> Cards { get; set; }
        public int Id { get; set; }
        #endregion

        #region Constructors
        public Deck()
        {
            Cards = new List<Card>();
        }
        #endregion

        #region Methods
        public List<Card> CloneCards()
        {
            List<Card> cardsClone = new List<Card>();
            for (int i = 0; i < Cards.Count; i++)
                cardsClone.Add(new Card(Cards[i]));
            return cardsClone;
        }
        #endregion
    }
}
