using MTG.Interfaces;
using MTG.Model.Objects;

namespace MTG.ArgumentDefintions.Triggered_Ability_Arguments
{
    public class ProtectionTriggeredAbilityArgs: ITriggeredAbilityArgs
    {
        public MTG.Model.Objects.Damage Damage { get; set; }
        public Card OriginCard { get; set; }
        public Card TargetCard { get; set; }
    }
}
