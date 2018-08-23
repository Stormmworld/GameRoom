using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Shatter : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=221
            *  
            *  Destroy target artifact.
            *  
            * Rulings
		2004-10-04: Regenerating artifacts can regenerate from this.

            *  
            */
        public Shatter() : base()
        {
            MultiverseId = 221;
            Name = "Shatter";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Shatter");
        }
        public Shatter(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
