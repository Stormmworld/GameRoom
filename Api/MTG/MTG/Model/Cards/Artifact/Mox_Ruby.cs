using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Mox_Ruby : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=35
            *  
            *  {T}: Add {R} to your mana pool.
            *  
            * Rulings

            *  
            */
        public Mox_Ruby() : base()
        {
            MultiverseId = 35;
            Name = "Mox Ruby";
            Add(Enumerations.CardType.Artifact);
            Add(new Abilities.Activated.ManaSource(new Mana() { Color = Enumerations.Colors.Red, Count = 1 }) { RequiresTap = true });
        }
        public Mox_Ruby(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
