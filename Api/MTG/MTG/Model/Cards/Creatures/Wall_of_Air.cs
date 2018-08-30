using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class Wall_of_Air : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=137
        *  
        *  Defender, flying (This creature can't attack, and it can block creatures with flying.)
        *  
        * Rulings

        *
        */
        public Wall_of_Air() : base()
        {
            MultiverseId = 137;
            Name = "Wall of Air";
            Set(1, 5);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Wall);
            Add(CardType.Creature);
            Add(new Defender());
            Add(new Flying());
        }
        public Wall_of_Air(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
