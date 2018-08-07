using MTG.Enumerations;
using System.Collections.Generic;

namespace MTG.DTO.Objects
{
    public class Band
    {
        public BandTypes BandType { get; set; }
        public List<Creature> BandMembers { get; set; }
        public Blocker Blocker { get; set; }
    }
}
