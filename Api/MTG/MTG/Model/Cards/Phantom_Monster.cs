using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Phantom_Monster : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=117
            *  
            *  Flying
            *  
            * Rulings

            *  
            */
        public Phantom_Monster() : base()
        {
            MultiverseId = 117;
            Name = "Phantom Monster";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Illusion);
	Add(Enumerations.CardType.Creature);
	_Power = 3;
		_Toughness = 3;

            throw new NotImplementedException("Phantom Monster");
        }
        public Phantom_Monster(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
