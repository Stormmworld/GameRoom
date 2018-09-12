using MTG.Enumerations;
using MTG.Interfaces.Ability_Interfaces;
using MTG.Interfaces.Argument_Interfaces;
using System;

namespace MTG.Model.Abilities._Base
{
    public class TriggeredAbility : Ability, ITriggeredAbility
    {
        #region Events
        public event EventHandler OnProcessing;
        #endregion

        #region Properties
        public EffectTrigger Trigger { get; private set; }
        #endregion

        #region Constructors
        internal TriggeredAbility(EffectTrigger trigger)
        {
            Trigger = trigger;
        }
        internal TriggeredAbility(EffectTrigger trigger, GamePhase removeAtPhase) :this(trigger)
        {
            RemoveAtPhase = removeAtPhase;
        }
        #endregion

        #region Methods
        public virtual void Process(ITriggeredAbilityArguments args)
        {
            try { OnProcessing?.Invoke(this, null); }
            catch { return; }
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            return GetType().Name;
        }
        #endregion
    }
}
