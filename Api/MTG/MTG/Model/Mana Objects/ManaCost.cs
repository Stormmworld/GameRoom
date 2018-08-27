using MTG.Interfaces.Mana_Interfaces;

namespace MTG.Model.Mana_Objects
{
    public class ManaCost : IManaCost
    {
        #region Properties
        public IMana Cost { get; private set; }
        public IMana AlternativeCost { get; private set; }
        #endregion

        #region Constructors
        public ManaCost(IMana cost)
        {
            Cost = cost;
        }
        public ManaCost(IMana cost, IMana alternativeCost):this(cost)
        {
            AlternativeCost = alternativeCost;
        }
        #endregion
    }
}
