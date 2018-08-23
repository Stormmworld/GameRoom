using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Wall_of_Wood : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=181
            *  
            *  Defender (This creature can't attack.)
            *  
            * Rulings

            *  
            */
        public Wall_of_Wood() : base()
        {
            MultiverseId = 181;
            Name = "Wall of Wood";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Wall);
	Add(Enumerations.CardType.Creature);
	_Power = 0;
		_Toughness = 3;

            throw new NotImplementedException("Wall of Wood");
        }
        public Wall_of_Wood(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
