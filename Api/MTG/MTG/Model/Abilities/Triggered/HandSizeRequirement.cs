using MTG.Enumerations;
using MTG.Model.Abilities._Base;
using MTG.Model.Data_Objects;

namespace MTG.Model.Abilities.Triggered
{
    public class HandSizeRequirement: TriggeredAbility
    {
        #region Properties
        public ActionType Action { get; private set; }
        public Comparator Comparator { get; private set; }
        public int DamageValue { get; private set; }
        public int Size { get; private set; }
        public Target Target { get; private set; }
        #endregion

        #region Constructors
        public HandSizeRequirement(EffectTrigger trigger, int size, Comparator comparator, ActionType action) : base(trigger)
        {
            Action = action;
            Comparator = comparator;
            Size = size;
        }
        public HandSizeRequirement(EffectTrigger trigger, int size, Comparator comparator, ActionType action, int damageValue) : this(trigger, size, comparator, action)
        {
            Action = action;
            Comparator = comparator;
            DamageValue = damageValue;
            Size = size;
        }
        #endregion

        #region Methods
        public void Assign(Target target)
        {
            Target = target;
        }
        #endregion
    }
}
