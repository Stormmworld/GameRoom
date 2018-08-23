using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Mox_Jet : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=33
            *  
            *  {T}: Add {B} to your mana pool.
            *  
            * Rulings

            *  
            */
        public Mox_Jet() : base()
        {
            MultiverseId = 33;
            Name = "Mox Jet";
            Add(Enumerations.CardType.Artifact);
            Add(new Abilities.Activated.ManaSource(new Mana() { Color = Enumerations.Colors.Black, Count = 1 }) { RequiresTap = true });
        }
        public Mox_Jet(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
