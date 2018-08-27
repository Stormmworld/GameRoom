using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Howl_from_Beyond : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=67
        *  
        *  Target creature gets +X/+0 until end of turn.
        *  
        * Rulings

        *
        */
        public Howl_from_Beyond() : base()
        {
            MultiverseId = 67;
            Name = "Howl from Beyond";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, true)));
            abilityCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(CardType.Instant);

            throw new NotImplementedException("Howl from Beyond");
        }
        public Howl_from_Beyond(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
