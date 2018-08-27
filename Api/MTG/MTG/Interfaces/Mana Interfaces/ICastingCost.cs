using System.Collections.Generic;

namespace MTG.Interfaces.Mana_Interfaces
{
    public interface ICastingCost
    {
        #region Collection Properties
        IReadOnlyList<IManaCost> ManaCosts { get; }
        #endregion

        #region Properties
        int XCost { get; }
        #endregion

        #region Methods
        void Add(int x);
        void Add(IManaCost manaCost);
        void Add(List<IManaCost> manaCosts);
        void Remove(int x);
        void Remove(IManaCost manaCost);
        #endregion
    }
}
