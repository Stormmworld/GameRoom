using MTG.Enumerations;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Triggered
{
    public class MoveToZone: TriggeredAbility 
    {
        #region Properties
        public TargetZone OriginZone { get; private set; }
        public TargetZone TargetZone { get; private set; }
        #endregion

        #region Constructors
        public MoveToZone(EffectTrigger trigger,  TargetZone targetZone) : base(trigger)
        {
            TargetZone = targetZone;
        }
        public MoveToZone(EffectTrigger trigger, TargetZone targetZone, TargetZone originZone) : this(trigger, targetZone)
        {
            OriginZone = originZone;
        }
        #endregion

        #region Methods
        public void AssignOrigin(TargetZone originZone)
        {
            OriginZone = originZone;
        }
        #endregion
    }
}
