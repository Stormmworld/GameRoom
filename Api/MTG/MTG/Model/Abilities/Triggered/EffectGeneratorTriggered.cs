using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Effect_Interfaces;
using MTG.Model.Abilities._Base;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities.Triggered
{
    public class EffectGeneratorTriggered: TriggeredAbility
    {
        #region Properties
        public Type EffectType { get; private set; }
        public IDamage Damage { get; internal set; }
        public AmountType AmountType { get; internal set; }
        public GamePhase EndingPhase { get; internal set; }
        public int Value { get; internal set; }
        public bool BoolValue { get; internal set; }
        public SubType SubType { get; internal set; }
        #endregion

        #region Constructors
        public EffectGeneratorTriggered(EffectTrigger trigger, ITargetRequirements targetRequirements, Type effectType) : base(trigger)
        {

        }
        #endregion

        #region Methods
        public virtual void Process(ITarget target, int xValue = 0)
        {
            throw new NotImplementedException("EffectGeneratorTriggered.Process");
        }
        #endregion
    }
}
