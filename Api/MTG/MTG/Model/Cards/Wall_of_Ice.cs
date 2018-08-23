using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Wall_of_Ice : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=180
            *  
            *  Defender (This creature can't attack.)
            *  
            * Rulings

            *  
            */
        public Wall_of_Ice() : base()
        {
            MultiverseId = 180;
            Name = "Wall of Ice";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Wall);
	Add(Enumerations.CardType.Creature);
	_Power = 0;
		_Toughness = 7;

            throw new NotImplementedException("Wall of Ice");
        }
        public Wall_of_Ice(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
