using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Mox_Sapphire : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=36
            *  
            *  {T}: Add {U} to your mana pool.
            *  
            * Rulings

            *  
            */
        public Mox_Sapphire() : base()
        {
            MultiverseId = 36;
            Name = "Mox Sapphire";
            Add(Enumerations.CardType.Artifact);
            Add(new Abilities.Activated.ManaSource(new Mana() { Color = Enumerations.Colors.Blue, Count = 1 }) { RequiresTap = true });
        }
        public Mox_Sapphire(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
