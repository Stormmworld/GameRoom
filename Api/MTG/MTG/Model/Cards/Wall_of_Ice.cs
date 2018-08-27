using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Wall_of_Ice : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=180
        *  
        *  Defender (This creature can't attack.)
        *  
        * Rulings

        *
        */
        public Wall_of_Ice() : base()
        {
            MultiverseId = 180;
            Name = "Wall of Ice";
            Set(0, 7);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Wall);
            Add(CardType.Creature);

            throw new NotImplementedException("Wall of Ice");
        }
        public Wall_of_Ice(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
