using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Water_Elemental : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=139
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Water_Elemental() : base()
        {
            MultiverseId = 139;
            Name = "Water Elemental";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Elemental);
	Add(Enumerations.CardType.Creature);
	_Power = 5;
		_Toughness = 4;

            throw new NotImplementedException("Water Elemental");
        }
        public Water_Elemental(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
