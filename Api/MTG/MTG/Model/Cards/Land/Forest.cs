using MTG.Model.Abilities.Activated;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Forest : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=288
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Forest() : base()
        {
            MultiverseId = 288;
            Name = "Forest";
            Add(Enumerations.SubType.Forest);
            Add(Enumerations.CardType.Land);
            Add(Enumerations.SuperType.Basic);
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Green, Count = 1 }) { RequiresTap = true });
        }
        public Forest(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
