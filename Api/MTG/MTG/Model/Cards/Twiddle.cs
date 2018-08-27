using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Twiddle : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=133
        *  
        *  You may tap or untap target artifact, creature, or land.
        *  
        * Rulings
        * 2004-10-04: This is not a toggle effect. If you use Twiddle to tap a card and before it takes effect your opponent taps it, Twiddle will not automatically untap the card.
        * 2004-10-04: The decision whether or not to tap or untap is made on resolution. This is not a modal spell.

        *
        */
        public Twiddle() : base()
        {
            MultiverseId = 133;
            Name = "Twiddle";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(CardType.Instant);

            throw new NotImplementedException("Twiddle");
        }
        public Twiddle(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
