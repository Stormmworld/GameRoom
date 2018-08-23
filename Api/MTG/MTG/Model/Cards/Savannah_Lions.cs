using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Savannah_Lions : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=269
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Savannah_Lions() : base()
        {
            MultiverseId = 269;
            Name = "Savannah Lions";
	Add(Enumerations.Colors.White);
	Add(Enumerations.SubType.Cat);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 1;

            throw new NotImplementedException("Savannah Lions");
        }
        public Savannah_Lions(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
