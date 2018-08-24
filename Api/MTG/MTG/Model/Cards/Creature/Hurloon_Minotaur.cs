using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Hurloon_Minotaur : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=206
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Hurloon_Minotaur() : base()
        {
            MultiverseId = 206;
            Name = "Hurloon Minotaur";
            _Power = 2;
            _Toughness = 3;
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Red, Count = 2 } });
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, Count = 1 } });
            Add(Enumerations.Colors.Red);
            Add(Enumerations.SubType.Minotaur);
            Add(Enumerations.CardType.Creature);
        }
        public Hurloon_Minotaur(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
