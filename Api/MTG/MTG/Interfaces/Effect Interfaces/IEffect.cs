using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using System;

namespace MTG.Interfaces.Effect_Interfaces
{
    public interface IEffect
    {
        #region Properties
        Guid BoundCardId { get; }
        GamePhase EndingPhase { get; }
        Guid EndingPhaseOwnerId { get; }
        ITarget Target { get; }
        #endregion

        #region Methods
        void Bind(Guid boundCardId);
        #endregion
    }
}
