using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Mana_Short : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=113
        *  
        *  Tap all lands target player controls and empty his or her mana pool.
        *  
        * Rulings
        * 2004-10-04: Since this is an instant, your opponent may use instants in response to the casting of this spell. Note that such spells and abilities will be resolved before the mana pool is emptied by the Mana Short. This makes it useless as a countermeasure for spells. To use it effectively, you need to use it during Upkeep and even then it will not prevent the use of instant spells and abilities.
        * 2004-10-04: If you play Mana Short in response to a spell, it will have no effect on that spell since the mana has already been paid.
        * 2004-10-04: It even taps lands that do not produce mana.

        *
        */
        public Mana_Short() : base()
        {
            MultiverseId = 113;
            Name = "Mana Short";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(CardType.Instant);

            throw new NotImplementedException("Mana Short");
        }
        public Mana_Short(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
