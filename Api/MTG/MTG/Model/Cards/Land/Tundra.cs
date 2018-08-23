using MTG.Enumerations;
using MTG.Model.Abilities;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Tundra : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=286
            *  
            *  T: Add White or Blue
            *  
            * Rulings
            *  This has the mana abilities associated with both of its basic land types.
            *  
            */
        public Tundra() : base()
        {
            MultiverseId = 286;
            Name = "Tundra";
            Add(CardType.Land);
            Add(SubType.Plains);
            Add(SubType.Island);
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Blue, Count = 1 }) { RequiresTap = true });
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.White, Count = 1 }) { RequiresTap = true });
        }
        public Tundra(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
