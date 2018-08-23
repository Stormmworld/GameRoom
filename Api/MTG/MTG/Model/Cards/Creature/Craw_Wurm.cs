using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Craw_Wurm : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=146
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Craw_Wurm() : base()
        {
            MultiverseId = 146;
            Name = "Craw Wurm";
            _Power = 6;
            _Toughness = 4;
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Green, Count = 2 } });
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, Count = 4 } });
            Add(Enumerations.Colors.Green);
            Add(Enumerations.SubType.Wurm);
            Add(Enumerations.CardType.Creature);
        }
        public Craw_Wurm(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
