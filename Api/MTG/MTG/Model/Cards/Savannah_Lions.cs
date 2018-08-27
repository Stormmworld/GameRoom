using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Savannah_Lions : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=269
        *  
        *  
        *  
        * Rulings

        *
        */
        public Savannah_Lions() : base()
        {
            MultiverseId = 269;
            Name = "Savannah Lions";
            Set(2, 1);
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Cat);
            Add(CardType.Creature);

            throw new NotImplementedException("Savannah Lions");
        }
        public Savannah_Lions(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
