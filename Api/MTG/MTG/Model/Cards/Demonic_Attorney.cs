using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Demonic_Attorney : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=58
            *  
            *  Remove Demonic Attorney from your deck before playing if you're not playing for ante.
Each player antes the top card of his or her library.
            *  
            * Rulings

            *  
            */
        public Demonic_Attorney() : base()
        {
            MultiverseId = 58;
            Name = "Demonic Attorney";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Demonic Attorney");
        }
        public Demonic_Attorney(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
