using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Triggered
{
    public class TriggeredDamage : TriggeredAbility
    {
        #region Properties
        public ITargetRequirements TargetRequirements { get; private set; }
        public IDamage Damage { get; private set; }
        #endregion

        #region Constructors
        public TriggeredDamage(EffectTrigger trigger, ITargetRequirements targetRequirements, IDamage damage) : base(trigger)
        {
            TargetRequirements = targetRequirements;
            Damage = damage;
        }
        #endregion
    }
}
