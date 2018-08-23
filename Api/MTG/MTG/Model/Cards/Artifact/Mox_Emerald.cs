using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Mox_Emerald : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=32
            *  
            *  {T}: Add {G} to your mana pool.
            *  
            * Rulings

            *  
            */
        public Mox_Emerald() : base()
        {
            MultiverseId = 32;
            Name = "Mox Emerald";
            Add(Enumerations.CardType.Artifact);
            Add(new Abilities.Activated.ManaSource(new Mana() { Color = Enumerations.Colors.Green, Count = 1 }) { RequiresTap = true });
        }
        public Mox_Emerald(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
