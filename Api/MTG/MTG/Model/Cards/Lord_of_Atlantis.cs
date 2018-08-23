using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Lord_of_Atlantis : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=110
            *  
            *  Other Merfolk creatures get +1/+1 and have islandwalk. (They can't be blocked as long as defending player controls an Island.)
            *  
            * Rulings

            *  
            */
        public Lord_of_Atlantis() : base()
        {
            MultiverseId = 110;
            Name = "Lord of Atlantis";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Merfolk);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 2;

            throw new NotImplementedException("Lord of Atlantis");
        }
        public Lord_of_Atlantis(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
