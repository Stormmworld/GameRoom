using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Island_Sanctuary : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=256
            *  
            *  If you would draw a card during your draw step, instead you may skip that draw. If you do, until your next turn, you can't be attacked except by creatures with flying and/or islandwalk.
            *  
            * Rulings
		2004-10-04: If you get multiple draws or you use a spell or ability during the draw step to draw extra cards, you can have the replacement effect apply to any one or all of those. You need only have it apply once to get the effect. If you skip more than one, there is no additional effect.
		2004-10-04: If the replacement effect is applied, the effect will continue until your next turn even if this card leaves the battlefield.
		2004-10-04: Since the draw is replaced, you can't use the same draw to do other things.

            *  
            */
        public Island_Sanctuary() : base()
        {
            MultiverseId = 256;
            Name = "Island Sanctuary";
	Add(Enumerations.Colors.White);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Island Sanctuary");
        }
        public Island_Sanctuary(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
