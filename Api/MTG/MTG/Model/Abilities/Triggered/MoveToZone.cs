using MTG.Enumerations;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Triggered
{
    public class MoveToZone: TriggeredAbility 
    {
        #region Properties
        public TargetZone OriginZone { get; private set; }
        public TargetZone TargetZone { get; private set; }
        public bool Optional { get; private set; }
        public InsertLocation InsertLocation { get; internal set; }
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
        public MoveToZone(EffectTrigger trigger, TargetZone targetZone, TargetZone originZone, bool optional) : this(trigger, targetZone, originZone)
        {
            Optional = optional;
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
