using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Mox_Pearl : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=34
            *  
            *  {T}: Add {W} to your mana pool.
            *  
            * Rulings

            *  
            */
        public Mox_Pearl() : base()
        {
            MultiverseId = 34;
            Name = "Mox Pearl";
            Add(Enumerations.CardType.Artifact);
            Add(new Abilities.Activated.ManaSource(new Mana() { Color = Enumerations.Colors.White, Count = 1 }) { RequiresTap = true });
        }
        public Mox_Pearl(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
