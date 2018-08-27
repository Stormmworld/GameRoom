using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Triggered
{
    public class AddCounter : TriggeredAbility
    {
        #region Properties
        public ICounter Counter { get; private set; }
        #endregion

        #region Constructors
        public AddCounter(Enumerations.EffectTrigger trigger, ICounter counter) : base(trigger)
        {
            Counter = counter;
        }
        #endregion
    }
}