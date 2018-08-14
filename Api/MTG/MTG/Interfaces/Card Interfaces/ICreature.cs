using MTG.ArgumentDefintions.Event_Arguments;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTG.Interfaces.Card_Interfaces
{
    public interface ICreature:IPermanant
    {
        #region Properties
        IReadOnlyList<int> Damage { get; }
        int Power { get; }
        int Toughness { get; }
        #endregion

        #region Methods
        void Apply(ApplyDamageEventArgs args);
        void Resolve();
        #endregion
    }
}
