using MTG.Enumerations;
using MTG.Interfaces;
using System.Collections.Generic;

namespace MTG.Model
{
    public class Card
    {
        public List<IAbility> Abilities { get; set; } 
        public List<CardType> CardTypes { get; set; }
    }
}
