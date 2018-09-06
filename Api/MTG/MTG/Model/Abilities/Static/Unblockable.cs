using MTG.Enumerations;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Static
{
    public class Unblockable:StaticAbility
    {
        #region Properties
        public SubType BlockableBySubType { get; private set; }
        public SubType NotBlockableBySubType { get; internal set; }
        #endregion

        #region Constructors
        public Unblockable() : base()
        {
        }
        public Unblockable(SubType blockableBySubType) : this()
        {
            BlockableBySubType = blockableBySubType;
        }
        #endregion
    }
}
