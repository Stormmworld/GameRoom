using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Wall_of_Water : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=138
        *  
        *  Defender (This creature can't attack.)
{U}: Wall of Water gets +1/+0 until end of turn.
        *  
        * Rulings

        *
        */
        public Wall_of_Water() : base()
        {
            MultiverseId = 138;
            Name = "Wall of Water";
            Set(0, 5);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Wall);
            Add(CardType.Creature);

            throw new NotImplementedException("Wall of Water");
        }
        public Wall_of_Water(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
