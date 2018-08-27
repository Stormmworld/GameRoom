using MTG.Interfaces.Data_Interfaces;
using System.Collections.Generic;

namespace MTG.Interfaces.Card_Interfaces
{
    public interface ICreature: IPermanent
    {

        #region Collection Properties
        IReadOnlyList<IDamage> Damage { get; }
        #endregion

        #region Properties
        int Power { get; }
        int Toughness { get; }
        #endregion

        #region Methods
        void Add(IDamage damage);
        void Set(int power, int toughness);
        void Remove(IDamage damage);
        #endregion
    }
}
