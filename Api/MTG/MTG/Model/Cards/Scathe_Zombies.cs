using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Scathe_Zombies : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=81
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Scathe_Zombies() : base()
        {
            MultiverseId = 81;
            Name = "Scathe Zombies";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Zombie);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 2;

            throw new NotImplementedException("Scathe Zombies");
        }
        public Scathe_Zombies(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
