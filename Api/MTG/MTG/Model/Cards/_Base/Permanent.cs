using MTG.Interfaces.Ability_Interfaces;
using MTG.Interfaces.Card_Interfaces;
using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Game;
using System;
using System.Collections.Generic;

namespace MTG.Model.Cards._Base
{
    public class Permanent : Card, IPermanent
    {
        #region Variables
        private List<IAbility> _Abilities;
        private List<IAura> _Auras;
        private List<ICounter> _Counters;
        #endregion

        #region Collection Properties
        public IReadOnlyList<IAbility> Abilities { get { return _Abilities.AsReadOnly(); } }
        public IReadOnlyList<IAura> Auras { get { return _Auras.AsReadOnly(); } }
        public IReadOnlyList<ICounter> Counters { get { return _Counters.AsReadOnly(); } }
        #endregion

        #region Properties
        public Player Controller { get; internal set; }
        public bool Tapped { get; private set; }
        #endregion

        #region Constructors
        internal Permanent()
        {
            _Abilities = new List<IAbility>();
            _Auras = new List<IAura>();
            _Counters = new List<ICounter>();
        }
        #endregion

        #region Methods
        public virtual void Add(IAbility ability)
        {
            throw new NotImplementedException();
        }
        public virtual void Add(IAura aura)
        {
            throw new NotImplementedException();
        }
        public virtual void Add(ICounter counter)
        {
            throw new NotImplementedException();
        }
        public virtual void Assign(ref Player controller)
        {
            Controller = controller;
        }
        public virtual void Has(IAbility ability)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove(IAbility ability)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove(IAura aura)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove(ICounter counter)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return GetType().Name;
        }
        #endregion
    }
}
