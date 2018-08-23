using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Zombie_Master : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=93
            *  
            *  Other Zombie creatures have swampwalk. (They can't be blocked as long as defending player controls a Swamp.)
Other Zombies have "{B}: Regenerate this permanent."
            *  
            * Rulings

            *  
            */
        public Zombie_Master() : base()
        {
            MultiverseId = 93;
            Name = "Zombie Master";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Zombie);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 3;

            throw new NotImplementedException("Zombie Master");
        }
        public Zombie_Master(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
