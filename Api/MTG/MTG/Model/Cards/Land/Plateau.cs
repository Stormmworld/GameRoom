using MTG.Enumerations;
using MTG.Model.Abilities;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Plateau : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=281
            *  
            *  T: Add Red or White
            *  
            * Rulings
            *  This has the mana abilities associated with both of its basic land types.
            *  
            */
        public Plateau() : base()
        {
            MultiverseId = 281;
            Name = "Plateau";
            Add(CardType.Land);
            Add(SubType.Mountian);
            Add(SubType.Plains);
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.White, Count = 1 }) { RequiresTap = true });
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Red, Count = 1 }) { RequiresTap = true });
        }
        public Plateau(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
