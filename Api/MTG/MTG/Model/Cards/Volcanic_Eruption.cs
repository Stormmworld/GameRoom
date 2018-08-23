using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Volcanic_Eruption : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=136
            *  
            *  Destroy X target Mountains. Volcanic Eruption deals damage to each creature and each player equal to the number of Mountains put into a graveyard this way.
            *  
            * Rulings
		2004-10-04: Can be used with X equal to zero. This is useful if no Mountains are on the battlefield.

            *  
            */
        public Volcanic_Eruption() : base()
        {
            MultiverseId = 136;
            Name = "Volcanic Eruption";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Volcanic Eruption");
        }
        public Volcanic_Eruption(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
