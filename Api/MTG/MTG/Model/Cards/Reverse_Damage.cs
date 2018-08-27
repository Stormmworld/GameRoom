using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Reverse_Damage : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=266
        *  
        *  The next time a source of your choice would deal damage to you this turn, prevent that damage. You gain life equal to the damage prevented this way.
        *  
        * Rulings
        * 2004-10-04: It only affects damage dealt by the source one time. If the source damages you a second time this turn, the damage will not be reversed.

        *
        */
        public Reverse_Damage() : base()
        {
            MultiverseId = 266;
            Name = "Reverse Damage";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            abilityCost.Add(new ManaCost(new Mana(Color.White, 1)));
            abilityCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Instant);

            throw new NotImplementedException("Reverse Damage");
        }
        public Reverse_Damage(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
