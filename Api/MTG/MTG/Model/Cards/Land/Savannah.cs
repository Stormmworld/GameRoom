using MTG.Enumerations;
using MTG.Model.Abilities;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Savannah : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=282
            *  
            *  T: Add Green or White
            *  
            * Rulings
            *  This has the mana abilities associated with both of its basic land types.
            *  
            */
        public Savannah() : base()
        {
            MultiverseId = 282;
            Name = "Savannah";
            Add(CardType.Land);
            Add(SubType.Forest);
            Add(SubType.Plains);
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.White, Count = 1 }) { RequiresTap = true });
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Green, Count = 1 }) { RequiresTap = true });
        }
        public Savannah(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
