using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Crusade : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=247
        *  
        *  White creatures get +1/+1.
        *  
        * Rulings

        *
        */
        public Crusade() : base()
        {
            MultiverseId = 247;
            Name = "Crusade";
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Crusade");
        }
        public Crusade(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
