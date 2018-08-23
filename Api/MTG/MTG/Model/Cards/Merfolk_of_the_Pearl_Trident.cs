using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Merfolk_of_the_Pearl_Trident : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=114
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Merfolk_of_the_Pearl_Trident() : base()
        {
            MultiverseId = 114;
            Name = "Merfolk of the Pearl Trident";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Merfolk);
	Add(Enumerations.CardType.Creature);
	_Power = 1;
		_Toughness = 1;

            throw new NotImplementedException("Merfolk of the Pearl Trident");
        }
        public Merfolk_of_the_Pearl_Trident(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
