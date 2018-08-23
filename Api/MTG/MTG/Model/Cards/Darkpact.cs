using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Darkpact : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=55
            *  
            *  Remove Darkpact from your deck before playing if you're not playing for ante.
You own target card in the ante. Exchange that card with the top card of your library.
            *  
            * Rulings

            *  
            */
        public Darkpact() : base()
        {
            MultiverseId = 55;
            Name = "Darkpact";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Darkpact");
        }
        public Darkpact(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
