using MTG.Enumerations;
using MTG.Model.Abilities.Activated;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Bayou : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=280
            *  
            *  T: Add Black or Green
            *  
            * Rulings
            *  This has the mana abilities associated with both of its basic land types.
            *  
            */
        public Bayou() : base()
        {
            MultiverseId = 280;
            Name = "Bayou";
            Add(CardType.Land);
            Add(SubType.Swamp);
            Add(SubType.Forest);
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Green, Count = 1 }) { RequiresTap = true });
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Black, Count = 1 }) { RequiresTap = true });
        }
        public Bayou(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
