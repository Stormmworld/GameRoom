using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Dwarven_Demolition_Team : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=190
            *  
            *  {T}: Destroy target Wall.
            *  
            * Rulings

            *  
            */
        public Dwarven_Demolition_Team() : base()
        {
            MultiverseId = 190;
            Name = "Dwarven Demolition Team";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Dwarf);
	Add(Enumerations.CardType.Creature);
	_Power = 1;
		_Toughness = 1;

            throw new NotImplementedException("Dwarven Demolition Team");
        }
        public Dwarven_Demolition_Team(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
