using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Static
{
    public class CounterGeneratorStatic: StaticAbility
    {
        #region Properties
        public ICounter Counter { get; private set; }
        public ITargetRequirements TargetRequirements { get; private set; }
        #endregion

        #region Constructors
        public CounterGeneratorStatic(ICounter counter, ITargetRequirements targetRequirements)
        {
            Counter = counter;
            TargetRequirements = targetRequirements;
        }
        #endregion
    }
}
