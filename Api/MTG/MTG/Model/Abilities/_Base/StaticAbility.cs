using MTG.Interfaces.Ability_Interfaces;

namespace MTG.Model.Abilities._Base
{
    public class StaticAbility:Ability, IStaticAbility
    {
        #region Constructors
        internal StaticAbility()
        {
        }
        internal StaticAbility(bool removeAtEndOfTurn)
        {
            RemoveAtEndOfTurn = removeAtEndOfTurn;
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
