using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Smoke : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=223
        *  
        *  Players can't untap more than one creature during their untap steps.
        *  
        * Rulings
        * 2004-10-04: Animated lands are affected by this spell. If on the battlefield with an effect that limits the number of land you untap, untapping an animated land will count as the one creature and the one land you can untap... thereby limiting you to one thing to be untapped.

        *
        */
        public Smoke() : base()
        {
            MultiverseId = 223;
            Name = "Smoke";
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Smoke");
        }
        public Smoke(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
