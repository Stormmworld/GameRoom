using MTG.Model.Abilities.Static;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Wall_of_Wood : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=181
            *  
            *  Defender (This creature can't attack.)
            *  
            * Rulings

            *  
            */
        public Wall_of_Wood() : base()
        {
            MultiverseId = 181;
            Name = "Wall of Wood";
            _Power = 0;
            _Toughness = 3;
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Green, Count = 1 } });
            Add(Enumerations.Colors.Green);
            Add(Enumerations.SubType.Wall);
            Add(Enumerations.CardType.Creature);
            Add(new Defender());
        }
        public Wall_of_Wood(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
