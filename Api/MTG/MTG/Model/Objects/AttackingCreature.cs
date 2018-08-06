using MTG.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model.Objects
{
    public class AttackingCreature
    {
        #region Variables
        #endregion

        #region Properties
        public Player AttackingPlayer { get; set; }
        public Blocker Blocker { get; set; }
        public Card Card { get; private set; }
        public AttackableTarget Defender { get; set; }
        public Guid Id { get; set; }
        #endregion

        #region Constructors
        public AttackingCreature(Card card)
        {
            Blocker = new Blocker();
            Card = card;
        }
        #endregion

        #region Methods
        public void AddBlocker(Card card, Guid bandId)
        {
            Blocker.Add(card, bandId);
        }
        public void AssignDamage(bool isFirstStrike)
        {
            Blocker.AssignDamage(isFirstStrike, Card, AttackingPlayer);
        }
        public void CommitDamage()
        {
            throw new NotImplementedException("AttackingCreature.CommitDamage");
        }
        #endregion
    }
}
