using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Force_of_Nature : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=150
            *  
            *  Trample (This creature can deal excess combat damage to defending player or planeswalker while attacking.)
At the beginning of your upkeep, Force of Nature deals 8 damage to you unless you pay {G}{G}{G}{G}.
            *  
            * Rulings

            *  
            */
        public Force_of_Nature() : base()
        {
            MultiverseId = 150;
            Name = "Force of Nature";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Elemental);
	Add(Enumerations.CardType.Creature);
	_Power = 8;
		_Toughness = 8;

            throw new NotImplementedException("Force of Nature");
        }
        public Force_of_Nature(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
