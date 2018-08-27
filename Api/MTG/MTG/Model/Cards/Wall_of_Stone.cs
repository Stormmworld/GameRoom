using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Wall_of_Stone : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=230
        *  
        *  Defender (This creature can't attack.)
        *  
        * Rulings

        *
        */
        public Wall_of_Stone() : base()
        {
            MultiverseId = 230;
            Name = "Wall of Stone";
            Set(0, 8);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Wall);
            Add(CardType.Creature);

            throw new NotImplementedException("Wall of Stone");
        }
        public Wall_of_Stone(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
