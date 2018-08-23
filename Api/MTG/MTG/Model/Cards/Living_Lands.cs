using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Living_Lands : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=165
            *  
            *  All Forests are 1/1 creatures that are still lands.
            *  
            * Rulings
		2008-08-01: A noncreature permanent that turns into a creature can attack, and its {T} abilities can be activated, only if its controller has continuously controlled that permanent since the beginning of his or her most recent turn. It doesn't matter how long the permanent has been a creature.

            *  
            */
        public Living_Lands() : base()
        {
            MultiverseId = 165;
            Name = "Living Lands";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Living Lands");
        }
        public Living_Lands(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
