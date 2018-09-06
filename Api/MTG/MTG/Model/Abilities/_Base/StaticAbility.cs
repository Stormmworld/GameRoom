using MTG.Enumerations;
using MTG.Interfaces.Ability_Interfaces;

namespace MTG.Model.Abilities._Base
{
    public class StaticAbility:Ability, IStaticAbility
    {
        #region Constructors
        internal StaticAbility()
        {
        }
        internal StaticAbility(GamePhase removeAtPhase)
        {
            RemoveAtPhase = removeAtPhase;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return GetType().Name;
        }
        #endregion
    }
}
