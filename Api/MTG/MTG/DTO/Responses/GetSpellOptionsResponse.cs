using MTG.DTO.Objects;
using System.Collections.Generic;

namespace MTG.DTO.Responses
{
    public class GetSpellOptionsResponse
    {
        #region Properties
        public List<SelectableAbility> Abilities { get; set; }
        public int SelectNumber { get; set; }
        #endregion
    }
}
