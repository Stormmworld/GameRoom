using System;
using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Effect_Interfaces;

namespace MTG.Model.Effects._Base
{
    public class Effect : IEffect
    {
        #region Properties
        public Guid BoundCardId { get; set; }
        public GamePhase EndingPhase { get; set; }
        public Guid EndingPhaseOwnerId { get; set; }
        public Guid Id { get; set; }
        public ITarget Target { get; set; }
        #endregion

        #region Constructors
        internal Effect()
        {
            Id = Guid.NewGuid();
        }
        #endregion

        #region Methods
        public virtual void Bind(Guid boundCardId)
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
