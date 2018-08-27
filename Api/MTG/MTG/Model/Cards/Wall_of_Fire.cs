using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Wall_of_Fire : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=229
        *  
        *  Defender (This creature can't attack.)
{R}: Wall of Fire gets +1/+0 until end of turn.
        *  
        * Rulings

        *
        */
        public Wall_of_Fire() : base()
        {
            MultiverseId = 229;
            Name = "Wall of Fire";
            Set(0, 5);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Wall);
            Add(CardType.Creature);

            throw new NotImplementedException("Wall of Fire");
        }
        public Wall_of_Fire(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
