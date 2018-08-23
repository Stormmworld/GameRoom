using MTG.Enumerations;
using MTG.Model.Abilities;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Scrubland : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=283
            *  
            *  T: Add White or Black
            *  
            * Rulings
            *  This has the mana abilities associated with both of its basic land types.
            *  
            */
        public Scrubland() : base()
        {
            MultiverseId = 283;
            Name = "Scrubland";
            Add(CardType.Land);
            Add(SubType.Swamp);
            Add(SubType.Plains);
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.White, Count = 1 }) { RequiresTap = true });
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Black, Count = 1 }) { RequiresTap = true });
        }
        public Scrubland(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
