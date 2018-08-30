using MTG.Interfaces.Ability_Interfaces;
using MTG.Interfaces.Data_Interfaces;
using System;
using System.Collections.Generic;

namespace MTG.Interfaces.Card_Interfaces
{
    public interface IPermanent: ICard
    {
        #region Collection Properties
        IReadOnlyList<IAbility> Abilities { get; }
        IReadOnlyList<IAura> Auras { get; }
        IReadOnlyList<ICounter> Counters { get; }
        #endregion

        #region Properties
        Guid ControllerId { get; }
        bool Tapped { get; }
        #endregion

        #region Methods
        void Add(IAbility ability);
        void Add(IAura aura);
        void Add(ICounter counter);
        void Has(IAbility ability);
        void Remove(IAbility ability);
        void Remove(IAura aura);
        void Remove(ICounter counter);
        #endregion
    }
}
