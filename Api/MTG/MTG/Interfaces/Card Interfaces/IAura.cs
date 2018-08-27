using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Effect_Interfaces;
using System.Collections.Generic;

namespace MTG.Interfaces.Card_Interfaces
{
    public interface IAura: IPermanent
    {
        #region Collection Properties
        IReadOnlyList<IEffect> AuraEffects { get; }
        #endregion

        #region Properties
        ITarget Target { get; }
        ITargetCardRequirements TargetCardRequirements { get; }
        #endregion

        #region Methods
        void Assign(ITarget target);
        #endregion
    }
}
