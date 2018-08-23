using MTG.Model.Abilities.Activated;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Island : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=292
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Island() : base()
        {
            MultiverseId = 292;
            Name = "Island";
            Add(Enumerations.SubType.Island);
            Add(Enumerations.CardType.Land);
            Add(Enumerations.SuperType.Basic);
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Blue, Count = 1 }) { RequiresTap = true });
        }
        public Island(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
