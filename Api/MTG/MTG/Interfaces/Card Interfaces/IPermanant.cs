using MTG.Enumerations;
using System;

namespace MTG.Interfaces.Card_Interfaces
{
    public interface IPermanant: ICard
    {
        #region Properties
        Guid ControllerId { get; }
        bool Tapped { get; }
        #endregion

        #region Methods
        void Destroy();
        void CheckTriggeredAbilities(EffectTrigger trigger, ITriggeredAbilityArgs args = null);
        #endregion
    }
}
