using System;
using MTG.Interfaces.Ability_Interfaces;

namespace MTG.Model.Abilities._Base
{
    public class Ability : IAbility
    {
        #region Events
        public event EventHandler OnPendingAction, OnEvent, OnCardEvent;
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        public Guid BoundCardId { get; internal set; }
        public bool RemoveAtEndOfTurn { get; internal set; }
        #endregion

        #region Constructors
        internal Ability()
        {
            Id = Guid.NewGuid();
        }
        #endregion

        #region Methods
        public void Bind(Guid boundCardId)
        {
            BoundCardId = boundCardId;
        }
        public override string ToString()
        {
            return GetType().Name;
        }
        #endregion
    }
}
