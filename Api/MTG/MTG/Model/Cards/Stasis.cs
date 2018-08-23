using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Stasis : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=128
            *  
            *  Players skip their untap steps.
At the beginning of your upkeep, sacrifice Stasis unless you pay {U}.
            *  
            * Rulings
		2004-10-04: Since there is no untap step, Phasing in/out won't happen.
		2004-10-04: Does not prevent cards from being untapped outside the untap step.

            *  
            */
        public Stasis() : base()
        {
            MultiverseId = 128;
            Name = "Stasis";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Stasis");
        }
        public Stasis(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
