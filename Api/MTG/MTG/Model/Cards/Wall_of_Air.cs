using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Wall_of_Air : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=137
            *  
            *  Defender, flying (This creature can't attack, and it can block creatures with flying.)
            *  
            * Rulings

            *  
            */
        public Wall_of_Air() : base()
        {
            MultiverseId = 137;
            Name = "Wall of Air";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Wall);
	Add(Enumerations.CardType.Creature);
	_Power = 1;
		_Toughness = 5;

            throw new NotImplementedException("Wall of Air");
        }
        public Wall_of_Air(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
