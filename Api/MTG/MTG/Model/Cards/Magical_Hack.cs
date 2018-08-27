using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Magical_Hack : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=111
        *  
        *  Change the text of target spell or permanent by replacing all instances of one basic land type with another. (For example, you may change "swampwalk" to "plainswalk." This effect lasts indefinitely.)
        *  
        * Rulings
        * 2004-10-04: Alters all occurrences of the chosen word in the text box and the type line of the given card.
        * 2004-10-04: Can target a card with no appropriate words on it, or even one with no words at all.
        * 2004-10-04: It can't change a word to the same word. It must be a different word.
        * 2004-10-04: It only changes what is printed on the card (or set on a token when it was created or set by a copy effect). It will not change any effects that are on the permanent.
        * 2004-10-04: You choose the words to change on resolution.
        * 2004-10-04: You can't change proper nouns (i.e. card names) such as "Island Fish Jasconius".
        * 2004-10-04: Changing the text of a spell will not allow you to change the targets of the spell because the targets were chosen when the spell was cast. The text change will (probably) cause it to be countered since the targets will be illegal.
        * 2004-10-04: If you change the text of a spell which is to become a permanent, the permanent will retain the text change until the effect wears off.
        * 2004-10-04: It can be used to change a land's type from one basic land type to another. For example, Forest can be changed to Island so it produces blue mana. It doesn't change the name of any permanent.

        *
        */
        public Magical_Hack() : base()
        {
            MultiverseId = 111;
            Name = "Magical Hack";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(CardType.Instant);

            throw new NotImplementedException("Magical Hack");
        }
        public Magical_Hack(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
