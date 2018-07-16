using MTGModel.Objects;
using System;
using System.Collections.Generic;

namespace MTG.Helpers
{
    public static class CardHelper
    {
        public static List<Card> ShuffleCards(List<Card> cards, int cycleCount)
        {
            List<Card> shuffledCards = new List<Card>();

            Random r = new Random();
            int randomIndex = 0;
            while (cards.Count > 0)
            {
                randomIndex = r.Next(0, cards.Count);
                shuffledCards.Add(cards[randomIndex]);
                cards.RemoveAt(randomIndex); 
            }

            if (cycleCount == 0)
                return shuffledCards;
            else
                return ShuffleCards(shuffledCards, cycleCount - 1);
        }
        public static List<Card> SelectRandomCards(List<Card> cards, int count)
        {
            List<Card> randomCards = new List<Card>();

            Random r = new Random();
            int randomIndex = 0;
            for (int i = 0; i < count; i++)
            {
                randomIndex = r.Next(0, cards.Count);
                randomCards.Add(cards[randomIndex]);
                cards.RemoveAt(randomIndex);
            }

            return randomCards;
        }
    }
}
