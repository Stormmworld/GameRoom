using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Static
{
    public class BlocksMultipleAttackers : StaticAbility
    {
        #region Properties
        public int AttackerCount { get; private set; }
        #endregion

        #region Constructors
        public BlocksMultipleAttackers(int attackerCount) :base()
        {
            AttackerCount = attackerCount;
        }
        #endregion
    }
}
