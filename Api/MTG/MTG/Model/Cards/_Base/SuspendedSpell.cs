using System.Collections.Generic;
using MTG.Interfaces.Card_Interfaces;
using MTG.Interfaces.Data_Interfaces;

namespace MTG.Model.Cards._Base
{
    public class SuspendedSpell : Spell, ISuspendedSpell
    {
        #region Variables
        private List<ICounter> _Counters;
        #endregion

        #region Collectin Properties
        public IReadOnlyList<ICounter> Counters { get { return _Counters.AsReadOnly(); } }
        #endregion

        #region Constructors
        internal SuspendedSpell()
        {
            _Counters = new List<ICounter>();
        }
        #endregion

        #region Methods
        public virtual void Add(ICounter counter)
        {
            _Counters.Add(counter);
        }
        public virtual void Remove(ICounter counter)
        {
            _Counters.Remove(counter);
        }
        public override string ToString()
        {
            return GetType().Name;
        }
        #endregion
    }
}
