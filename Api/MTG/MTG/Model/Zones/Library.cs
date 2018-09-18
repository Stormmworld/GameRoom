using MTG.Interfaces.Card_Interfaces;
using MTG.Model.Zones._Base;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model.Zones
{
    public class Library : Zone
    {
        #region Constructors
        public Library() : base()
        {
        }
        #endregion

        #region Methods
        public List<ICard> Draw(int drawCount)
        {
            List<ICard> retVal = new List<ICard>();
            for (int i = 0; i < drawCount; i++)
            {
                ICard cardToDraw = Cards.ToArray()[0];
                retVal.Add(cardToDraw);
                Remove(cardToDraw.Id);
            }
            return retVal;
        }
        public void Shuffle(int shuffleCount)
        {
        }
        #endregion
    }
}
