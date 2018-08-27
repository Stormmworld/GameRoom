using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Pearled_Unicorn : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=261
        *  
        *  
        *  
        * Rulings

        *
        */
        public Pearled_Unicorn() : base()
        {
            MultiverseId = 261;
            Name = "Pearled Unicorn";
            Set(2, 2);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Unicorn);
            Add(CardType.Creature);

            throw new NotImplementedException("Pearled Unicorn");
        }
        public Pearled_Unicorn(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
