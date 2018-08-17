using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Interfaces.Ability_Interfaces;
using System.Collections.Generic;

namespace MTG.Model.Objects
{
    public class StackEntry
    {
        #region Properties
        public int Id { get; set; }
        public Card Card { get; set; }
        public List<ICastingAbility> CastingAbilities { get; set; }
        public IEffect Effect { get; set; }
        public StackEntryType EntryType { get; set; }
        public string ImageUrl { get; set; }
        public Target Target { get; set; }
        #endregion

        #region Constructors
        public StackEntry(int id, Card card)
        {
            CastingAbilities = new List<ICastingAbility>();
            Id = id;
            EntryType = StackEntryType.Spell;
            Card = card;
            ImageUrl = Card.ImageUrl;
        }
        public StackEntry(int id, IEffect effect, string imageUrl)
        {
            CastingAbilities = new List<ICastingAbility>();
            Id = id;
            EntryType = StackEntryType.Effect;
            Effect = effect;
            ImageUrl = imageUrl;
        }
        #endregion
    }
}
