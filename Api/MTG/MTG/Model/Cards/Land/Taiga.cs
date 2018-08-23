using MTG.Enumerations;
using MTG.Model.Abilities.Activated;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Taiga : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=284
            *  
            *  T: Add Red or Green
            *  
            * Rulings
            *  This has the mana abilities associated with both of its basic land types.
            *  
            */
        public Taiga() : base()
        {
            MultiverseId = 284;
            Name = "Taiga";
            Add(CardType.Land);
            Add(SubType.Forest);
            Add(SubType.Mountian);
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Red, Count = 1 }) { RequiresTap = true });
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Green, Count = 1 }) { RequiresTap = true });
        }
        public Taiga(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
