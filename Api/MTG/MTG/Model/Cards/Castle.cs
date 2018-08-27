using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Castle : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=240
        *  
        *  Untapped creatures you control get +0/+2.
        *  
        * Rulings

        *
        */
        public Castle() : base()
        {
            MultiverseId = 240;
            Name = "Castle";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Castle");
        }
        public Castle(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
