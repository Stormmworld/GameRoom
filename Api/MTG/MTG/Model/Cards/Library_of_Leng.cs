using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Library_of_Leng : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=28
        *  
        *  You have no maximum hand size.
If an effect causes you to discard a card, discard it, but you may put it on top of your library instead of into your graveyard.
        *  
        * Rulings
        * 2004-10-04: This effect has no effect on the cards being put into the graveyard from a library, because they are not "discarded".
        * 2004-10-04: You can't use the Library of Leng ability to place a discarded card on top of your library when you discard a card as a cost, because costs aren't effects.
        * 2004-10-04: The discard triggers anything else that triggers on discards.
        * 2004-10-04: You can look at a randomly discarded card before deciding where it goes.
        * 2004-10-04: The ability applies any time a spell or ability has you discard as part of its effect. It does not matter if you or your opponent control the spell or ability. The discard is forced because it is an effect.
        * 2004-10-04: If more than one card is discarded due to a single effect, the Library allows you to decide whether or not to use it on each of the cards. You get to decide the order the cards are placed on the library if more than one goes there.
        * 2004-10-04: Since the card goes directly to the library, the card is not revealed unless the spell or ability requiring the discard specifically says it is.
        * 2004-10-04: The ability replaces the normal discard action with a discard action that puts the card on the library instead of the graveyard.
        * 2009-10-01: If multiple effects modify your hand size, apply them in timestamp order. For example, if you put Null Profusion (an enchantment that says your maximum hand size is two) onto the battlefield and then put Library of Leng onto the battlefield, you'll have no maximum hand size. However, if those permanents entered the battlefield in the opposite order, your maximum hand size would be two.

        *
        */
        public Library_of_Leng() : base()
        {
            MultiverseId = 28;
            Name = "Library of Leng";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Library of Leng");
        }
        public Library_of_Leng(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
