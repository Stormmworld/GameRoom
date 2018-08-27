using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Mana_Flare : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=210
        *  
        *  Whenever a player taps a land for mana, that player adds one mana to his or her mana pool of any type that land produced.
        *  
        * Rulings
        * 2004-10-04: If the land produces more than one color of mana at a single time, its controller chooses which of those types is produced by Mana Flare's ability.
        * 2004-10-04: The types of mana are white, blue, black, red, green, and colorless.
        * 2004-10-04: When used with lands that can produce multiple colors, Mana Flare produces one additional mana of the same color that was produced. It can't give a mana of a color that wasn't produced.
        * 2004-10-04: Only produces extra mana when land is tapped for mana, not when tapped by some other effect.
        * 2004-10-04: Mana Flare adds one of whatever color the land produces after applying any land type or color changing effects.
        * 2004-10-04: This is a triggered mana ability.
        * 2007-09-16: Does not copy any restrictions on the mana, such as with Mishra's Workshop or Pillar of the Paruns.
        * 2007-09-16: Produces only one additional mana, regardless of how much was produced by tapping the land.

        *
        */
        public Mana_Flare() : base()
        {
            MultiverseId = 210;
            Name = "Mana Flare";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Mana Flare");
        }
        public Mana_Flare(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
