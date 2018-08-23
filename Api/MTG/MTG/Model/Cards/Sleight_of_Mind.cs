using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Sleight_of_Mind : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=126
            *  
            *  Change the text of target spell or permanent by replacing all instances of one color word with another. (For example, you may change "target black spell" to "target blue spell." This effect lasts indefinitely.)
            *  
            * Rulings
		2004-10-04: You can't Sleight proper nouns (i.e. card names). This means that you can't affect a "Black Vise".
		2004-10-04: Can target a card with no color words on it.
		2004-10-04: Can't change a color word to the same color word. It must be a different word.
		2004-10-04: Alters all occurrences of the chosen word in the text box and the type line of the given card.
		2004-10-04: Can target a card with no appropriate words on it, or even one with no words at all.
		2004-10-04: It can't change a word to the same word. It must be a different word.
		2004-10-04: It only changes what is printed on the card (or set on a token when it was created or set by a copy effect). It will not change any effects that are on the permanent.
		2004-10-04: You choose the words to change on resolution.
		2004-10-04: Changing the text of a spell will not allow you to change the targets of the spell because the targets were chosen when the spell was cast. The text change will (probably) cause it to be countered since the targets will be illegal.
		2004-10-04: If you change the text of a spell which is to become a permanent, the permanent will retain the text change until the effect wears off.

            *  
            */
        public Sleight_of_Mind() : base()
        {
            MultiverseId = 126;
            Name = "Sleight of Mind";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Sleight of Mind");
        }
        public Sleight_of_Mind(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
