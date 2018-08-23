using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Goblin_King : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=202
            *  
            *  Other Goblin creatures get +1/+1 and have mountainwalk. (They can't be blocked as long as defending player controls a Mountain.)
            *  
            * Rulings
		2005-08-01: Goblin King now has the Goblin creature type and its ability has been reworded to affect *other* Goblins. This means that if two Goblin Kings are on the battlefield, each gives the other a bonus.

            *  
            */
        public Goblin_King() : base()
        {
            MultiverseId = 202;
            Name = "Goblin King";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Goblin);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 2;

            throw new NotImplementedException("Goblin King");
        }
        public Goblin_King(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
