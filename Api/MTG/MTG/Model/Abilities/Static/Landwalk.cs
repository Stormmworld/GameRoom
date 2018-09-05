using MTG.Enumerations;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Static
{
    public class Landwalk : StaticAbility
    {
        #region Properties
        public SubType LandType { get; private set; }
        #endregion

        #region Constructors
        public Landwalk(SubType landType):base()
        {
            LandType = landType;
        }
        #endregion
    }
}
