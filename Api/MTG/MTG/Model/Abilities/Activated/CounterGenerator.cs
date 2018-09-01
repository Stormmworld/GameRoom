using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Abilities._Base;
using System.Collections.Generic;

namespace MTG.Model.Abilities.Activated
{
    public class CounterGenerator: ActivatedAbility
    {
        #region Properties
        public ICounter Counter { get; internal set; }
        #endregion

        #region Constructors
        public CounterGenerator(bool requiresTap, List<IManaCost> activationCost, ICounter counter) : base(requiresTap)
        {
            Add(activationCost);
            Counter = counter;
        }
        public CounterGenerator(bool requiresTap, List<IManaCost> activationCost, ICounter counter, bool removeAtEndOfTurn) : base(requiresTap, removeAtEndOfTurn)
        {
            Add(activationCost);
            Counter = counter;
        }
        #endregion
    }
}
