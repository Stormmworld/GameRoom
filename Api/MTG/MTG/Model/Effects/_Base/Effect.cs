using System;
using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Effect_Interfaces;

namespace MTG.Model.Effects._Base
{
    public class Effect : IEffect
    {
        #region Properties
        public Guid BoundCardId { get; internal set; }
        public Guid Id { get; private set; }
        public ITarget Target { get; private set; }
        public int XValue { get; private set; }
        #endregion

        #region Constructors
        private Effect()
        {
            Id = Guid.NewGuid();
        }
        public Effect(ITarget target) : this()
        {
            Assign(target);
        }
        #endregion

        #region Methods
        public virtual void Assign(ITarget target)
        {
            Target = target;
        }
        public void AssignXValue(int xValue)
        {
            XValue = xValue;
        }
        public override string ToString()
        {
            return GetType().Name;
        }
        #endregion
    }
}
