using System;

namespace MTG.Interfaces.Ability_Interfaces
{
    public interface IAbility
    {
        #region Events
        event EventHandler OnPendingAction, OnEvent, OnCardEvent;
        #endregion

        #region Properties
        Guid Id { get; }
        Guid BoundCardId { get; }
        #endregion

        #region Methods
        void Bind(Guid boundCardId);
        #endregion
    }
}
