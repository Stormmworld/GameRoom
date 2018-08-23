using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Demonic_Tutor : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=60
            *  
            *  Search your library for a card and put that card into your hand. Then shuffle your library.
            *  
            * Rulings
		2004-10-04: You pick a card on resolution.
		2004-10-04: You don't reveal the card to your opponent.
		2004-10-04: This card is put directly into your hand. It is not drawn.

            *  
            */
        public Demonic_Tutor() : base()
        {
            MultiverseId = 60;
            Name = "Demonic Tutor";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Demonic Tutor");
        }
        public Demonic_Tutor(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
