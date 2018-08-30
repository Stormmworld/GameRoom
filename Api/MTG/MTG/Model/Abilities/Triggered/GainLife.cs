using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Triggered
{
    public class GainLife: TriggeredAbility
    {
        #region Properties
        public int LifeValue { get; private set; }
        public ITargetCardRequirements TargetCardRequirements { get; private set; }
        #endregion

        #region Constructors
        public GainLife(EffectTrigger trigger, ITargetCardRequirements targetCardRequirements, int lifeValue) : base(trigger)
        {
            LifeValue = lifeValue;
            TargetCardRequirements = targetCardRequirements;
        }
        #endregion
    }
}
