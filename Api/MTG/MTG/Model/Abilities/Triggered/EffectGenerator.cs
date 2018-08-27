using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Effect_Interfaces;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Triggered
{
    public class EffectGenerator : TriggeredAbility
    {
        #region Properties
        public IEffect Effect { get; private set; }
        public ITargetRequirements TargetRequirements { get; private set; }
        #endregion

        #region Constructors
        public EffectGenerator(Enumerations.EffectTrigger trigger, ITargetRequirements targetRequirements, IEffect effect) : base(trigger)
        {
            Effect = effect;
            TargetRequirements = targetRequirements;
        }
        #endregion
    }
}
