using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Abilities._Base;
using MTG.Model.Mana_Objects;

namespace MTG.Model.Abilities.Activated
{
    public class CounterGenerator: ActivatedAbility
    {
        #region Properties
        public ICounter Counter { get; internal set; }
        #endregion

        #region Constructors
        public CounterGenerator(bool requiresTap, CastingCost activationCost, ICounter counter) : base(requiresTap)
        {
            ActivationCost = activationCost;
            Counter = counter;
        }
        public CounterGenerator(bool requiresTap, CastingCost activationCost, ICounter counter, bool removeAtEndOfTurn) : base(requiresTap, removeAtEndOfTurn)
        {
            ActivationCost = activationCost;
            Counter = counter;
        }
        #endregion
    }
}
