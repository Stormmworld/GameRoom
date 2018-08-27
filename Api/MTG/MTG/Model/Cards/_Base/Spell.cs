using System.Collections.Generic;
using MTG.Interfaces.Ability_Interfaces;
using MTG.Interfaces.Card_Interfaces;

namespace MTG.Model.Cards._Base
{
    public class Spell : Card, ISpell
    {
        #region Variables
        private List<ICastingAbility> _SpellAbilities;
        #endregion

        #region Collection Properties
        public IReadOnlyList<ICastingAbility> SpellAbilities { get { return _SpellAbilities.AsReadOnly(); } }
        #endregion

        #region Constructors
        internal Spell()
        {
            _SpellAbilities = new List<ICastingAbility>();
        }
        #endregion

        #region Methods
        public virtual void Add(ICastingAbility spellAbility)
        {
            _SpellAbilities.Add(spellAbility);
        }
        public virtual void GetOptions()
        {
            throw new System.NotImplementedException("Spell.GetOptions");
        }
        public virtual void Remove(ICastingAbility spellAbility)
        {
            _SpellAbilities.Remove(spellAbility);
        }
        public override string ToString()
        {
            return GetType().Name;
        }
        #endregion
    }
}
