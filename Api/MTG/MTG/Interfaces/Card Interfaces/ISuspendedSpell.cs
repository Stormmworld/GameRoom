using MTG.Interfaces.Data_Interfaces;
using System.Collections.Generic;

namespace MTG.Interfaces.Card_Interfaces
{
    public interface ISuspendedSpell: ISpell
    {
        #region Collection Properties
        IReadOnlyList<ICounter> Counters { get ; }
        #endregion

        #region Methods
        void Add(ICounter counter);
        void Remove(ICounter counter);
        #endregion
    }
}
