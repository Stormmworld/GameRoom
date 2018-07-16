using MTG.Enumerations;
using MTG.Interfaces;
using System;
using System.Collections.Generic;

namespace MTG.Model.Zones
{
    /*
     *  https://mtg.gamepedia.com/Hand
        402.1. The hand is where a player holds cards that have been drawn. Cards can be put into a player’s 
                hand by other effects as well. At the beginning of the game, each player draws a number of 
                cards equal to that player’s starting hand size, normally seven. 
                (See rule 103, “Starting the Game.”)
        402.2. Each player has a maximum hand size, which is normally seven cards. A player may have any 
                number of cards in their hand, but as part of their cleanup step, the player must discard 
                excess cards down to the maximum hand size.
        402.3. A player may arrange their hand in any convenient fashion and look at it at any time. A player 
                can’t look at the cards in another player’s hand but may count those cards at any time.
     */
    public class Hand: IZone
    {
        #region Properties
        public int MaximumSize { get; set; }
        public List<Card> Cards { get; set; }
        public bool HandRevealed { get; set; }
        #endregion

        #region Constructors
        public Hand()
        {
            Cards = new List<Card>();
            MaximumSize = 7;
        }
        #endregion

        #region Methods
        public bool LandMulligan()
        {
            var landInHand = Cards.FindAll(o=>o.CardTypes.Contains(CardType.Land));
            if (landInHand.Count < 2)
                return true;
            else
                return landInHand.Count == MaximumSize;
        }
        #endregion
    }
}
