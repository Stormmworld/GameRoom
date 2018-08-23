using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Roc_of_Kher_Ridges : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=218
            *  
            *  Flying
            *  
            * Rulings

            *  
            */
        public Roc_of_Kher_Ridges() : base()
        {
            MultiverseId = 218;
            Name = "Roc of Kher Ridges";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Bird);
	Add(Enumerations.CardType.Creature);
	_Power = 3;
		_Toughness = 3;

            throw new NotImplementedException("Roc of Kher Ridges");
        }
        public Roc_of_Kher_Ridges(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
