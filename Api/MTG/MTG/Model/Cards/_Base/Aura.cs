using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Interfaces.Card_Interfaces;
using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Effect_Interfaces;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards._Base
{
    public class Aura : Permanent, IAura
    {
        #region Variables
        private List<IEffect> _AuraEffects;
        #endregion

        #region Collection Properties
        public IReadOnlyList<IEffect> AuraEffects { get { return _AuraEffects.AsReadOnly(); } }
        #endregion

        #region Properties
        public ITarget Target { get; private set; }
        public ITargetCardRequirements TargetCardRequirements { get; private set; }
        #endregion

        #region Constructors
        internal Aura(ITargetCardRequirements targetCardRequirements)
        {
            _AuraEffects = new List<IEffect>();
            TargetCardRequirements = targetCardRequirements;
            Assign(new Target());
        }
        #endregion

        #region Methods
        public override void Add(IEffect auraEffect)
        {
            _AuraEffects.Add(auraEffect);
        }
        public virtual void Assign(ITarget target)
        {
            Target = target;
        }
        public override bool Has(IEffect auraEffect)
        {
            return _AuraEffects.Contains(auraEffect);
        }
        public override void Remove(IEffect auraEffect)
        {
            _AuraEffects.Remove(auraEffect);
        }
        public override string ToString()
        {
            return GetType().Name;
        }
        #endregion
    }
}
