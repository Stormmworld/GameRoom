using MTG.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTG.Model.Pending_Actions
{
    public class Scry : IPendingAction
    {
        /*
         701.17. Scry
                701.17a To “scry N” means to look at the top N cards of your library, put any number of them on the 
                            bottom of your library in any order and the rest on top of your library in any order.
                701.17b If a player is instructed to scry 0, no scry event occurs. Abilities that trigger whenever 
                            a player scries won’t trigger.
                701.17c If multiple players scry at once, each of those players looks at the top cards of their 
                            library at the same time. Those players decide in APNAP order (see rule 101.4) where 
                            to put those cards, then those cards move at the same time.
             */
        #region Properties
        public Guid ActionPlayerId { get; set; }
        public Guid Id { get; private set; }
        public int ScryCount { get; set; }
        #endregion

        #region Constructors
        public Scry()
        {
            Id = Guid.NewGuid();
        }
        #endregion

    }
}
