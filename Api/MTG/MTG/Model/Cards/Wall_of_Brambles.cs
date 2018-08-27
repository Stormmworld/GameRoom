using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Wall_of_Brambles : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=179
        *  
        *  Defender (This creature can't attack.)
{G}: Regenerate Wall of Brambles.
        *  
        * Rulings

        *
        */
        public Wall_of_Brambles() : base()
        {
            MultiverseId = 179;
            Name = "Wall of Brambles";
            Set(2, 3);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Plant);
            Add(SubType.Wall);
            Add(CardType.Creature);

            throw new NotImplementedException("Wall of Brambles");
        }
        public Wall_of_Brambles(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
