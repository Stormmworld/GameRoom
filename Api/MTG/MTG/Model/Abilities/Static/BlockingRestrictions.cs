using MTG.Enumerations;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Static
{
    public class BlockingRestrictions : StaticAbility
    {
        #region Properties
        public Comparator Comparison { get; private set; }
        public int PowerValue { get; private set; }
        #endregion

        #region Constructors
        public BlockingRestrictions(int powerValue, Comparator comparison)
        {
            Comparison = comparison;
            PowerValue = powerValue;
        }
        #endregion
    }
}
