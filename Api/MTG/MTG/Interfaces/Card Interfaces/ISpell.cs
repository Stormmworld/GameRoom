using MTG.Interfaces.Ability_Interfaces;
using System.Collections.Generic;

namespace MTG.Interfaces.Card_Interfaces
{
    public interface ISpell: ICard
    {
        #region Collection Properties
        IReadOnlyList<ICastingAbility> SpellAbilities { get; }
        #endregion

        #region Methods
        void Add(ICastingAbility spellAbility);
        void GetOptions();
        void Remove(ICastingAbility spellAbility);
        #endregion
    }
}
