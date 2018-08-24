using MTG.Model.Abilities.Activated;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Sunglasses_of_Urza : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=42
            *  
            *  You may spend white mana as though it were red mana.
            *  
            * Rulings

            *  
            */
        public Sunglasses_of_Urza() : base()
        {
            MultiverseId = 42;
            Name = "Sunglasses of Urza";
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, Count = 3 } });
            Add(Enumerations.CardType.Artifact);
            Add(new ManaConversion(Enumerations.Colors.White, Enumerations.Colors.Red));
        }
        public Sunglasses_of_Urza(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
