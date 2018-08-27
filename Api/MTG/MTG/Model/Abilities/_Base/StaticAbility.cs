using MTG.Interfaces.Ability_Interfaces;

namespace MTG.Model.Abilities._Base
{
    public class StaticAbility:Ability, IStaticAbility
    {
        #region Methods
        public override string ToString()
        {
            return GetType().Name;
        }
        #endregion
    }
}
