using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Disrupting_Scepter : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=13
            *  
            *  {3}, {T}: Target player discards a card. Activate this ability only during your turn.
            *  
            * Rulings
		2004-10-04: You can use it on yourself.

            *  
            */
        public Disrupting_Scepter() : base()
        {
            MultiverseId = 13;
            Name = "Disrupting Scepter";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Disrupting Scepter");
        }
        public Disrupting_Scepter(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
