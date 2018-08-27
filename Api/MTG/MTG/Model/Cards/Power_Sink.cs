using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Power_Sink : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=120
        *  
        *  Counter target spell unless its controller pays {X}. If he or she doesn't, that player taps all lands with mana abilities he or she controls and empties his or her mana pool.
        *  
        * Rulings
        * 2004-10-04: Does not increase the mana cost of the spell. It just requires a separate expenditure in order for it to succeed.
        * 2004-10-04: When this spell resolves, you either pay X mana or let your lands become tapped. The lands that become tapped are not "tapped for mana". If you choose to pay, you may pay the X mana using whatever mana abilities you want to use.
        * 2010-03-01: Only lands that actually have mana abilities will get tapped. This includes basic lands and lands with mana abilities printed on them, as well as lands which have been granted a mana ability by some effect.

        *
        */
        public Power_Sink() : base()
        {
            MultiverseId = 120;
            Name = "Power Sink";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, true)));
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(CardType.Instant);

            throw new NotImplementedException("Power Sink");
        }
        public Power_Sink(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
