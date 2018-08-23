using MTG.Enumerations;
using MTG.Model.Abilities.Activated;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Underground_Sea : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=287
            *  
            *  T: Add Blue or Black
            *  
            * Rulings
            *  This has the mana abilities associated with both of its basic land types.
            *  
            */
        public Underground_Sea() : base()
        {
            MultiverseId = 287;
            Name = "Underground Sea";
            Add(CardType.Land);
            Add(SubType.Swamp);
            Add(SubType.Island);
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Blue, Count = 1 }) { RequiresTap = true });
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Black, Count = 1 }) { RequiresTap = true });
        }
        public Underground_Sea(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
