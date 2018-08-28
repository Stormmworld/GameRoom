using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Activated
{
    public class CounterGenerator: ActivatedAbility
    {
        #region Constructors
        public CounterGenerator(bool requiresTap) : base(requiresTap)
        {

        }
        public CounterGenerator(bool requiresTap, bool removeAtEndOfTurn) : base(requiresTap, removeAtEndOfTurn)
        {

        }
        #endregion
    }
}
