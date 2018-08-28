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
        private CounterGenerator(bool requiresTap) : base(requiresTap)
        {

        }
        public CounterGenerator(bool requiresTap, ICounter counter) : this(requiresTap)
        {
            Counter = counter;
        }
        public CounterGenerator(bool requiresTap,  ICounter counter,CastingCost activationCost) : this( requiresTap,counter)
        {
            ActivationCost = activationCost;
        }
        #endregion
    }
}
