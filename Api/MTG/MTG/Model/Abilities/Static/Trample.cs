using MTG.Enumerations;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Static
{
    public class Trample:StaticAbility
    {
        #region Constructors
        internal Trample():base()
        {
        }
        internal Trample(GamePhase removeAtPhase) :base(removeAtPhase)
        {
        }
        #endregion
    }
}
