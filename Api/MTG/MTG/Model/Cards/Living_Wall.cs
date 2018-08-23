using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Living_Wall : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=29
            *  
            *  Defender (This creature can't attack.)
{1}: Regenerate Living Wall.
            *  
            * Rulings

            *  
            */
        public Living_Wall() : base()
        {
            MultiverseId = 29;
            Name = "Living Wall";
	Add(Enumerations.SubType.Wall);
	Add(Enumerations.CardType.Artifact);
	Add(Enumerations.CardType.Creature);
	_Power = 0;
		_Toughness = 6;

            throw new NotImplementedException("Living Wall");
        }
        public Living_Wall(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
