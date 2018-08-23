using MTG.Model.Abilities;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Swamp : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=277
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Swamp() : base()
        {
            MultiverseId = 277;
            Name = "Swamp";
            Add(Enumerations.SubType.Swamp);
            Add(Enumerations.CardType.Land);
            Add(Enumerations.SuperType.Basic);
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Black, Count = 1 }) { RequiresTap = true });
        }
        public Swamp(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
