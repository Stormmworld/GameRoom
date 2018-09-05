using System;

namespace MTG.Model.Game
{
    public class Player
    {
        #region Properties
        public Guid Id { get; private set; }
        #endregion

        #region Constructors
        public Player()
        {
            Id = Guid.NewGuid();
        }
        #endregion
    }
}
