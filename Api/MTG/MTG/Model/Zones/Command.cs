using MTG.Interfaces;
using System.Collections.Generic;

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
        #region Properties
        public List<Card> Cards { get; set; }
        #endregion

        #region Constructors
        public Command()
        {
            Cards = new List<Card>();
        }
        #endregion
    }
}
