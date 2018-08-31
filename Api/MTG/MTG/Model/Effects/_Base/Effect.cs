using System;
using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Effect_Interfaces;

namespace MTG.Model.Effects._Base
{
    public class Effect : IEffect
    {
        #region Properties
        public Guid BoundCardId { get; internal set; }
        public GamePhase EndingPhase { get; private set; }
        public Guid EndingPhaseOwnerId { get; private set; }
        public Guid Id { get; private set; }
        public ITarget Target { get; private set; }
        #endregion

        #region Constructors
        private Effect()
        {
            Id = Guid.NewGuid();
        }
        public Effect(GamePhase endingPhase, Guid endingPhaseOwnerId) : this()
        {
            Assign(endingPhase, endingPhaseOwnerId);
        }
        public Effect(GamePhase endingPhase, Guid endingPhaseOwnerId, Guid boundCardId) : this(endingPhase, endingPhaseOwnerId)
        {
            Bind(boundCardId);
        }
        public Effect(GamePhase endingPhase, Guid endingPhaseOwnerId, ITarget target) : this(endingPhase, endingPhaseOwnerId)
        {
            Assign(target);
        }
        public Effect(GamePhase endingPhase, Guid endingPhaseOwnerId, ITarget target, Guid boundCardId) : this(endingPhase, endingPhaseOwnerId, target)
        {
            Bind(boundCardId);
        }
        #endregion

        #region Methods
        public virtual void Assign(GamePhase endingPhase, Guid endingPhaseOwnerId)
        {
            EndingPhase = endingPhase;
            EndingPhaseOwnerId = endingPhaseOwnerId;
        }
        public virtual void Assign(ITarget target)
        {
            Target = target;
        }
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
