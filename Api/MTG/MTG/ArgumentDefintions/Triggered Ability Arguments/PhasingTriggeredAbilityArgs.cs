using MTG.Interfaces;
using MTG.Model.Objects;

namespace MTG.ArgumentDefintions.Triggered_Ability_Arguments
{
    public class PhasingTriggeredAbilityArgs : ITriggeredAbilityArgs
    {
        public Card OriginCard { get; set; }
    }
}
