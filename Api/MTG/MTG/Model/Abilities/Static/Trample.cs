using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Static
{
    public class Trample:StaticAbility
    {
        #region Constructors
        internal Trample():base()
        {
        }
        internal Trample(bool removeAtEndOfTurn):base(removeAtEndOfTurn)
        {
            RemoveAtEndOfTurn = removeAtEndOfTurn;
        }
        #endregion
    }
}
