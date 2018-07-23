using MTGModel.Objects;
using System.Collections.Generic;

namespace MTG.Model.Objects
{
    public class AttackingCreature
    {
        #region Properties
        public int AttackingPlayerId { get; set; }
        public List<Card> Blockers { get; set; }
        public Card Card { get; set; }
        public int DefendingPlayerId { get; set; }
        public int Id { get; set; }
        #endregion
    }
}
