using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Island_Sanctuary : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=256
        *  
        *  If you would draw a card during your draw step, instead you may skip that draw. If you do, until your next turn, you can't be attacked except by creatures with flying and/or islandwalk.
        *  
        * Rulings
        * 2004-10-04: If you get multiple draws or you use a spell or ability during the draw step to draw extra cards, you can have the replacement effect apply to any one or all of those. You need only have it apply once to get the effect. If you skip more than one, there is no additional effect.
        * 2004-10-04: If the replacement effect is applied, the effect will continue until your next turn even if this card leaves the battlefield.
        * 2004-10-04: Since the draw is replaced, you can't use the same draw to do other things.

        *
        */
        public Island_Sanctuary() : base()
        {
            MultiverseId = 256;
            Name = "Island Sanctuary";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Island Sanctuary");
        }
        public Island_Sanctuary(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
