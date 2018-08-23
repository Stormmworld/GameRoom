using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Smoke : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=223
            *  
            *  Players can't untap more than one creature during their untap steps.
            *  
            * Rulings
		2004-10-04: Animated lands are affected by this spell. If on the battlefield with an effect that limits the number of land you untap, untapping an animated land will count as the one creature and the one land you can untap... thereby limiting you to one thing to be untapped.

            *  
            */
        public Smoke() : base()
        {
            MultiverseId = 223;
            Name = "Smoke";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Smoke");
        }
        public Smoke(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
