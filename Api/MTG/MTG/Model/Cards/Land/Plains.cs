using MTG.Model.Abilities;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Plains : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=294
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Plains() : base()
        {
            MultiverseId = 294;
            Name = "Plains";
            Add(Enumerations.SubType.Plains);
            Add(Enumerations.CardType.Land);
            Add(Enumerations.SuperType.Basic);
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.White, Count = 1 }) { RequiresTap = true });
        }
        public Plains(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
