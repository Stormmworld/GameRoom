using MTG.Interfaces;
using MTG.Model.Objects;

namespace MTG.ArgumentDefintions.Triggered_Ability_Arguments
{
    public class DamageTriggeredAbilityArgs: ITriggeredAbilityArgs
    {
        #region Properties
        public Target Target { get; set; }
        #endregion
    }
}
