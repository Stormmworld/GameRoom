using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Dark_Ritual : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=54
        *  
        *  Add {B}{B}{B} to your mana pool.
        *  
        * Rulings

        *
        */
        public Dark_Ritual() : base()
        {
            MultiverseId = 54;
            Name = "Dark Ritual";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(CardType.Instant);

            throw new NotImplementedException("Dark Ritual");
        }
        public Dark_Ritual(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
