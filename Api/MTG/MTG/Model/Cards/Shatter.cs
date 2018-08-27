using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Shatter : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=221
        *  
        *  Destroy target artifact.
        *  
        * Rulings
        * 2004-10-04: Regenerating artifacts can regenerate from this.

        *
        */
        public Shatter() : base()
        {
            MultiverseId = 221;
            Name = "Shatter";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            abilityCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Instant);

            throw new NotImplementedException("Shatter");
        }
        public Shatter(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
