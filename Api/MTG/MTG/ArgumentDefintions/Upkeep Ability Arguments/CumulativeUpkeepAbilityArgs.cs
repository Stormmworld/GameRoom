using MTG.Interfaces;
using MTG.Model.Objects;
using System;

namespace MTG.ArgumentDefintions.Upkeep_Ability_Arguments
{
    public class CumulativeUpkeepAbilityArgs: IUpkeepAbilityArgs
    {
        public Card OriginCard { get; set; }
        public Guid OriginPlayerId { get; set; }
    }
}
