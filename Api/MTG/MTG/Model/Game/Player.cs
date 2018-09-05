using MTG.Model.Zones;
using System;

namespace MTG.Model.Game
{
    public class Player
    {
        #region Properties
        public Guid Id { get; private set; }
        public BattleField BattleField { get; private set; }
        #endregion

        #region Constructors
        public Player()
        {
            BattleField = new BattleField();
            Id = Guid.NewGuid();
        }
        #endregion
    }
}
