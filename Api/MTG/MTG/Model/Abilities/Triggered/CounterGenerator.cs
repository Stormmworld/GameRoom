using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Triggered
{
    public class CounterGenerator: TriggeredAbility
    {
        #region Properties
        public ICounter Counter { get; private set; }
        public ITargetRequirements TargetRequirements { get; private set; }
        #endregion

        #region Constructors
        public CounterGenerator(Enumerations.EffectTrigger trigger, ITargetRequirements targetRequirements, ICounter counter) : base(trigger)
        {
            TargetRequirements = targetRequirements;
            Counter = counter;
        }
        #endregion
    }
}
