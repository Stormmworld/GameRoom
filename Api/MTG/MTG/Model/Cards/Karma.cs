using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Karma : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=257
        *  
        *  At the beginning of each player's upkeep, Karma deals damage to that player equal to the number of Swamps he or she controls.
        *  
        * Rulings
        * 2004-10-04: Amount of damage is determined when the ability resolves and not when it is placed on the stack.

        *
        */
        public Karma() : base()
        {
            MultiverseId = 257;
            Name = "Karma";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Karma");
        }
        public Karma(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
