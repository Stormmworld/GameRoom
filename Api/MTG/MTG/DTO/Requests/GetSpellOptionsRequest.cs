using System;

namespace MTG.DTO.Requests
{
    public class GetSpellOptionsRequest
    {
        #region Properties
        public Guid PlayerId { get; set; }
        public Guid SpellId { get; set; }
        #endregion
    }
}
