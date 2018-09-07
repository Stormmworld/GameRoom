using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Abilities._Base;
using System;

namespace MTG.Model.Abilities.Triggered
{
    public class TargetModifierTriggered: TriggeredAbility
    {
        #region Properties
        public ITarget NewTarget { get; private set; }
        public ITargetRequirements NewTargetRequirements { get; private set; }
        public Guid CardToRetarget { get; private set; }
        #endregion

        #region Constructors
        public TargetModifierTriggered(EffectTrigger trigger, Guid cardToRetarget, ITargetRequirements newTargetRequirements) : base(trigger)
        {
            NewTargetRequirements = newTargetRequirements;
            CardToRetarget = cardToRetarget;
        }
        #endregion
    }
}
