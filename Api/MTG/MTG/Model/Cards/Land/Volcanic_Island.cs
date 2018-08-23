using MTG.Enumerations;
using MTG.Model.Abilities;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Volcanic_Island : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=585
            *  
            *  T: Add Blue or Red
            *  
            * Rulings
            *  This has the mana abilities associated with both of its basic land types.
            *  
            */
        public Volcanic_Island() : base()
        {
            MultiverseId = 585;
            Name = "Volcanic Island";
            Add(CardType.Land);
            Add(SubType.Mountian);
            Add(SubType.Island);
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Blue, Count = 1 }) { RequiresTap = true });
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Green, Count = 1 }) { RequiresTap = true });
        }
        public Volcanic_Island(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
