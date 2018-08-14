using MTG.Enumerations;
using MTG.Model.Objects;
using System.Collections.Generic;

namespace MTG.Interfaces.Card_Interfaces
{
    public interface ISpell: ICard
    {
        #region Properties
        IReadOnlyList<TargetType> TargetTypes { get; }
        TargetScope TargetScope { get; }
        #endregion

        #region Methods
        void Add(TargetType targetType);
        void Process(Target target);
        void Remove(TargetType targetType);
        #endregion
    }
}
