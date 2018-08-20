using System;

namespace MTG.Model.Objects
{
    public class AttackingCreature
    {
        #region Events
        public event EventHandler OnEffectTriggered; 
        #endregion

        #region Variables
        #endregion

        #region Properties
        public Player AttackingPlayer { get; set; }
        public Blocker Blocker { get; set; }
        public Card Card { get; private set; }
        public Guid Id { get { return Card.Id; } }
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
            Blocker.OnEffectTriggered += OnEffectTriggered;
            Blocker.AssignDamage(isFirstStrike, Card, AttackingPlayer);
            Blocker.OnEffectTriggered -= OnEffectTriggered;
        }
        public void CommitDamage()
        {
        }
        #endregion
    }
}
