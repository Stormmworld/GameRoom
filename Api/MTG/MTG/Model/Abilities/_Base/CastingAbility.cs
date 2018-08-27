using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Interfaces.Ability_Interfaces;
using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Data_Objects;

namespace MTG.Model.Abilities._Base
{
    public class CastingAbility : Ability, ICastingAbility
    {
        #region Properties
        public ICastingCost CastingCost { get; private set; }
        public bool IsAddOn { get; private set; }
        public bool RequiresTarget { get; private set; }
        public ITarget Target { get; private set; }
        public ITargetRequirements TargetRequirements { get; private set; }
        #endregion

        #region Constructors
        private CastingAbility(ICastingCost castingCost, bool isAddOn) : base()
        {
            TargetRequirements = new TargetRequirements(TargetScope.None, new List<TargetType>());
            CastingCost = castingCost;
            IsAddOn = isAddOn;
        }
        internal CastingAbility(ICastingCost castingCost, ITarget target, bool isAddOn) :this(castingCost, isAddOn)
        {
            TargetRequirements = new TargetRequirements(TargetScope.Single, new List<TargetType>() { target.Type });
            RequiresTarget = false;
            Target = target;
        }
        internal CastingAbility(ICastingCost castingCost, ITargetRequirements targetRequirements, bool isAddOn) : this(castingCost, isAddOn)
        {
            RequiresTarget = true;
            TargetRequirements = targetRequirements;
        }
        #endregion

        #region Methods
        public void Assign(ITarget target)
        {
            Target = target;
        }
        public void Process()
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            return GetType().Name;
        }
        #endregion

    }
}
