using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Manabarbs : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=211
        *  
        *  Whenever a player taps a land for mana, Manabarbs deals 1 damage to that player.
        *  
        * Rulings
        * 2004-10-04: This card has a triggered ability that causes a separate effect for 1 point of damage each time a land is tapped for mana.
        * 2009-10-01: This ability is not a mana ability. It goes on the stack and can be responded to.
        * 2009-10-01: The ability will trigger each time a land is tapped for mana. Each ability is separate.
        * 2009-10-01: If any lands are tapped for mana while a player is casting a spell or activating an ability, Manabarbs's ability will trigger that many times and wait. When the player finishes casting that spell or activating that ability, it's put on the stack, then Manabarbs's triggered abilities are put on the stack on top of it. The Manabarbs abilities will resolve first.
        * 2009-10-01: On the other hand, a player can tap lands for mana, let the Manabarbs triggered abilities be put on the stack, and then respond to those abilities by casting an instant or activating an ability using that mana. In that case, the spell or ability will resolve first.

        *
        */
        public Manabarbs() : base()
        {
            MultiverseId = 211;
            Name = "Manabarbs";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Manabarbs");
        }
        public Manabarbs(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
