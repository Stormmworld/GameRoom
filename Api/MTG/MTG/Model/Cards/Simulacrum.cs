using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Simulacrum : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=84
        *  
        *  You gain life equal to the damage dealt to you this turn. Simulacrum deals damage to target creature you control equal to the damage dealt to you this turn.
        *  
        * Rulings
        * 2004-10-04: You can't use Simulacrum on Loss of Life, just damage.
        * 2004-10-04: This is not damage prevention or redirection. It actually is life gain and newly dealt damage.
        * 2008-08-01: Simulacrum is the source of the damage. If an effect needs to know a characteristic of the damage's source (Protection from Black, for instance), it will see the damage coming from Simulacrum.

        *
        */
        public Simulacrum() : base()
        {
            MultiverseId = 84;
            Name = "Simulacrum";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            abilityCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(CardType.Instant);

            throw new NotImplementedException("Simulacrum");
        }
        public Simulacrum(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
