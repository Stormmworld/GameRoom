using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Hurloon_Minotaur : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=206
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Hurloon_Minotaur() : base()
        {
            MultiverseId = 206;
            Name = "Hurloon Minotaur";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Minotaur);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 3;

            throw new NotImplementedException("Hurloon Minotaur");
        }
        public Hurloon_Minotaur(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
