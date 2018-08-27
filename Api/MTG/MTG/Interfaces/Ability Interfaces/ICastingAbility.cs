using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Mana_Interfaces;

namespace MTG.Interfaces.Ability_Interfaces
{
    public interface ICastingAbility : IAbility
    {
        #region Properties
        ICastingCost CastingCost { get; }
        bool IsAddOn { get; }
        bool RequiresTarget { get; }
        ITarget Target { get; }
        ITargetRequirements TargetRequirements { get; }
        #endregion

        #region Methods
        void Assign(ITarget target);
        void Process();
        #endregion
    }
}
