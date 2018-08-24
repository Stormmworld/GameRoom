using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Sol_Ring : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=40
            *  
            *  {T}: Add {C}{C} to your mana pool.
            *  
            * Rulings

            *  
            */
        public Sol_Ring() : base()
        {
            MultiverseId = 40;
            Name = "Sol Ring";
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, Count = 1 } });
            Add(Enumerations.CardType.Artifact);
            Add(new Abilities.Activated.ManaSource(new Mana() { Color = Enumerations.Colors.Colorless, Count = 2 }) { RequiresTap = true });
        }
        public Sol_Ring(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
