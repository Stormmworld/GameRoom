using MTG.Model.Abilities;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Mountain : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=290
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Mountain() : base()
        {
            MultiverseId = 290;
            Name = "Mountain";
            Add(Enumerations.SubType.Mountain);
            Add(Enumerations.CardType.Land);
            Add(Enumerations.SuperType.Basic);
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Red, Count = 1 }) { RequiresTap = true });
        }
        public Mountain(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
