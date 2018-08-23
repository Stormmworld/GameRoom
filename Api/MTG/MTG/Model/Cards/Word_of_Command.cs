using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Word_of_Command : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=92
            *  
            *  Look at target opponent's hand and choose a card from it. You control that player until Word of Command finishes resolving. The player plays that card if able. While doing so, the player can activate mana abilities only if they're from lands he or she controls and only if mana they produce is spent to activate other mana abilities of lands he or she controls and/or play that card. If the chosen card is cast as a spell, you control the player while that spell is resolving.
            *  
            * Rulings
		2004-10-04: To "play a card" is to either cast a spell or to put a land onto the battlefield using the main phase special action.
		2009-10-01: You do get to choose which lands get tapped. You can make them choose an optional mana generating ability of the land that they tap, such as making them tap and sacrifice the land instead of just tap it.
		2011-01-01: Word of Command can't be used to force a player to play a card that isn't in his or her hand.
		2011-01-01: You control the player while this spell is resolving, which means you get to see anything he or she can see. If that player is required to search his or her library as part of playing the card or as part of its resolution if it's cast as a spell, then you can see the cards in that player's library as well.
		2011-01-01: Your opponent can't counter the Word of Command after letting you look at his or her hand, but they can attempt to counter the spell you force them to cast.
		2011-01-01: You may Command your opponent to play a land (if they have not already done so this turn).
		2011-01-01: You must order your opponent to play the chosen card if it is possible to do so.
		2011-01-01: If there is a non-mana way to cast a spell, as with Pitch Spells, you may require that way to be used if it is possible to do so.
		2011-01-01: Since this spell is an instant, your opponent gets a chance to respond to it as normal. Once this spell resolves, you look at your opponent's hand and choose a card. Note that it is common practice to respond to Word of Command by using up any spells or mana you have prior to letting it resolve.
		2011-01-01: During the resolution of this spell, that player plays the chosen card.
		2016-07-13: While controlling another player, you can see all cards in the game that player can see. This includes cards in that player's hand, face-down cards that player controls, and any cards in that player's library the player may look at.
		2016-07-13: Controlling a player doesn't allow you to look at that player's sideboard. If an effect instructs that player to choose a card from outside the game, you can't have that player choose any card.

            *  
            */
        public Word_of_Command() : base()
        {
            MultiverseId = 92;
            Name = "Word of Command";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Word of Command");
        }
        public Word_of_Command(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
