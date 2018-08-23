using MTG.Enumerations;
using MTG.Model.Abilities.Activated;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Tropical_Island : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=285
            *  
            *  T: Add Green or Blue
            *  
            * Rulings
            *  This has the mana abilities associated with both of its basic land types.
            *  
            */
        public Tropical_Island() : base()
        {
            MultiverseId = 285;
            Name = "Tropical Island";
            Add(CardType.Land);
            Add(SubType.Forest);
            Add(SubType.Island);
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Blue, Count = 1 }) { RequiresTap = true });
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Green, Count = 1 }) { RequiresTap = true });
        }
        public Tropical_Island(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
