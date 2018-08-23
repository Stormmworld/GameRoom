using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Fire_Elemental : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=196
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Fire_Elemental() : base()
        {
            MultiverseId = 196;
            Name = "Fire Elemental";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Elemental);
	Add(Enumerations.CardType.Creature);
	_Power = 5;
		_Toughness = 4;

            throw new NotImplementedException("Fire Elemental");
        }
        public Fire_Elemental(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
