using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Kormus_Bell : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=27
            *  
            *  All Swamps are 1/1 black creatures that are still lands.
            *  
            * Rulings
		2004-10-04: The lands are both lands and creatures at the same time. They are affected by anything that affects either permanent type.
		2004-10-04: It affects Swamps controlled by any and all players.
		2008-08-01: A noncreature permanent that turns into a creature can attack, and its {T} abilities can be activated, only if its controller has continuously controlled that permanent since the beginning of his or her most recent turn. It doesn't matter how long the permanent has been a creature.

            *  
            */
        public Kormus_Bell() : base()
        {
            MultiverseId = 27;
            Name = "Kormus Bell";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Kormus Bell");
        }
        public Kormus_Bell(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
