using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Pirate_Ship : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=118
            *  
            *  Pirate Ship can't attack unless defending player controls an Island.
{T}: Pirate Ship deals 1 damage to target creature or player.
When you control no Islands, sacrifice Pirate Ship.
            *  
            * Rulings

            *  
            */
        public Pirate_Ship() : base()
        {
            MultiverseId = 118;
            Name = "Pirate Ship";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Human);
	Add(Enumerations.SubType.Pirate);
	Add(Enumerations.CardType.Creature);
	_Power = 4;
		_Toughness = 3;

            throw new NotImplementedException("Pirate Ship");
        }
        public Pirate_Ship(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
