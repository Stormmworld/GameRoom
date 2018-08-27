using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Wall_of_Wood : Creature
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
            Set(0, 3);
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Wall);
            Add(CardType.Creature);

            throw new NotImplementedException("Wall of Wood");
        }
        public Wall_of_Wood(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
