using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class Wall_of_Swords : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=273
        *  
        *  Defender (This creature can't attack.)
        *  Flying
        *  
        * Rulings
        *
        */
        public Wall_of_Swords() : base()
        {
            MultiverseId = 273;
            Name = "Wall of Swords";
            Set(3, 5);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Wall);
            Add(CardType.Creature);
            Add(new Defender());
            Add(new Flying());
        }
        public Wall_of_Swords(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
