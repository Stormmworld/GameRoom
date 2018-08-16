using MTG.Enumerations;
using MTG.Interfaces;

namespace MTG.Model.Objects
{
    public class StackEntry
    {
        #region Properties
        public int Id { get; set; }
        public Card Card { get; set; }
        public IEffect Effect { get; set; }
        public StackEntryType EntryType { get; set; }
        public string ImageUrl { get; set; }
        public Target Target { get; set; }
        #endregion

        #region Constructors
        public StackEntry(int id, Card card)
        {
            Id = id;
            EntryType = StackEntryType.Spell;
            Card = card;
            ImageUrl = Card.ImageUrl;
        }
        public StackEntry(int id, IEffect effect, string imageUrl)
        {
            Id = id;
            EntryType = StackEntryType.Effect;
            Effect = effect;
            ImageUrl = imageUrl;
        }
        #endregion
    }
}
