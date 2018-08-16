using MTG.Enumerations;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;

namespace MTG.DTO.Objects
{
    public class Spell
    {
        #region Properties
        public Guid CardId { get; set; }
        public bool Enabled { get; set; }
        public string ImageUrl { get; set; }
        public bool IsLand {get;set;}
        public string Name { get; set; }
        public List<TargetType> Targets { get; set; }
        #endregion

        #region Constructors
        public Spell()
        {
        }
        public Spell(Card card, bool enabled) : this()
        {
            CardId = card.Id;
            ImageUrl = card.ImageUrl;
            IsLand = card.HasType(CardType.Land);
            Name = card.Name;
        }
        #endregion

        #region Methods
        public static bool InstantSpeed(Card card)
        {
            if (card.HasType(CardType.Instant))
                return true;
            //else if (card.HasAbility(typeof(Flash))) 
            //    return true
            else
                return false;
        }
        #endregion
    }
}
