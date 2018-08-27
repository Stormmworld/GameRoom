using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Death_Ward : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=248
        *  
        *  Regenerate target creature.
        *  
        * Rulings

        *
        */
        public Death_Ward() : base()
        {
            MultiverseId = 248;
            Name = "Death Ward";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Instant);

            throw new NotImplementedException("Death Ward");
        }
        public Death_Ward(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
