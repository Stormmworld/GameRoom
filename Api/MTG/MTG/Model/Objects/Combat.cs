using MTG.Model.Objects;
using System;
using System.Collections.Generic;

namespace MTG.Model.Objects
{
    public class Combat
    {
        #region Variables
        private List<AttackingCreature> _Attackers;
        private List<Band> _AttackingBands;
        #endregion

        #region Properties
        public IReadOnlyCollection<AttackingCreature> Attackers { get { return _Attackers.AsReadOnly(); } }
        public IReadOnlyCollection<Band> AttackingBands { get { return _AttackingBands.AsReadOnly(); } }
        #endregion

        #region Constructors
        public Combat()
        {
            _Attackers = new List<AttackingCreature>();
            _AttackingBands = new List<Band>();
        }
        #endregion

        #region Methods
        public void AddAttacker(Card card)
        {
            throw new NotImplementedException("Combat.AddAttacker");
        }
        public void AddBlocker(Card card)
        {
            throw new NotImplementedException("Combat.AddBlocker");
        }
        public void Process()
        {
            throw new NotImplementedException("Combat.Process");
        }
        #endregion
    }
}
