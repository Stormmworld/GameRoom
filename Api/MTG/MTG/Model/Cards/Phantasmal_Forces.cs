using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Phantasmal_Forces : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=115
            *  
            *  Flying
At the beginning of your upkeep, sacrifice Phantasmal Forces unless you pay {U}.
            *  
            * Rulings

            *  
            */
        public Phantasmal_Forces() : base()
        {
            MultiverseId = 115;
            Name = "Phantasmal Forces";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Illusion);
	Add(Enumerations.CardType.Creature);
	_Power = 4;
		_Toughness = 1;

            throw new NotImplementedException("Phantasmal Forces");
        }
        public Phantasmal_Forces(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
