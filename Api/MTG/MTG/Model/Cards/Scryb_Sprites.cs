using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Scryb_Sprites : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=171
            *  
            *  Flying
            *  
            * Rulings

            *  
            */
        public Scryb_Sprites() : base()
        {
            MultiverseId = 171;
            Name = "Scryb Sprites";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Faerie);
	Add(Enumerations.CardType.Creature);
	_Power = 1;
		_Toughness = 1;

            throw new NotImplementedException("Scryb Sprites");
        }
        public Scryb_Sprites(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
