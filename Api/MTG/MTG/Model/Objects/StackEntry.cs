using MTG.Enumerations;
using MTGModel.Objects;
using System.Collections.Generic;

namespace MTG.Model.Objects
{
    public class StackEntry
    {
        #region Properties
        public int Id { get; set; }
        public Card Card { get; set; }
        public Effect Effect { get; set; }
        public StackEntryType EntryType { get; set; }
        public string ImageUrl { get; set; }
        #endregion

        #region Constructors
        public StackEntry(int id, Card card)
        {
            Id = id;
            EntryType = StackEntryType.Spell;
            Card = card;
            ImageUrl = Card.ImageUrl;
        }
        public StackEntry(int id, Effect effect, string imageUrl)
        {
            Id = id;
            EntryType = StackEntryType.Effect;
            Effect = effect;
            ImageUrl = imageUrl;
        }
        #endregion
    }
}
