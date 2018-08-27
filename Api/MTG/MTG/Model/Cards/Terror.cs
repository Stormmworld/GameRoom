using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Terror : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=86
        *  
        *  Destroy target nonartifact, nonblack creature. It can't be regenerated.
        *  
        * Rulings

        *
        */
        public Terror() : base()
        {
            MultiverseId = 86;
            Name = "Terror";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            abilityCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(CardType.Instant);

            throw new NotImplementedException("Terror");
        }
        public Terror(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
