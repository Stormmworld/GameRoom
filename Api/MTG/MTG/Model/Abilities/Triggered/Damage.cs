using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Triggered
{
    public class Damage:TriggeredAbility
    {
        #region Properties
        public ITargetRequirements TargetRequirements { get; private set; }
        public int Value { get; private set; }
        #endregion

        #region Constructors
        public Damage(int value, EffectTrigger trigger, ITargetRequirements targetRequirements) : base(trigger)
        {
            TargetRequirements = targetRequirements;
            Value = value;
        }
        #endregion
    }
}
