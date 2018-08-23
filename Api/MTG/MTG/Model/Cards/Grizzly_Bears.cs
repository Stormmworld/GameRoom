using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Grizzly_Bears : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=155
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Grizzly_Bears() : base()
        {
            MultiverseId = 155;
            Name = "Grizzly Bears";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Bear);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 2;

            throw new NotImplementedException("Grizzly Bears");
        }
        public Grizzly_Bears(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
