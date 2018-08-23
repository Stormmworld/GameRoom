using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Forcefield : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=14
            *  
            *  {1}: The next time an unblocked creature of your choice would deal combat damage to you this turn, prevent all but 1 of that damage.
            *  
            * Rulings
		2004-10-04: This can't be used to prevent damage caused by a blocked creature with Trample ability.

            *  
            */
        public Forcefield() : base()
        {
            MultiverseId = 14;
            Name = "Forcefield";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Forcefield");
        }
        public Forcefield(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
