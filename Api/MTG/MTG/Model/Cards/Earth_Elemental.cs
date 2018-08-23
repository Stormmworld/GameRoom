using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Earth_Elemental : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=192
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Earth_Elemental() : base()
        {
            MultiverseId = 192;
            Name = "Earth Elemental";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Elemental);
	Add(Enumerations.CardType.Creature);
	_Power = 4;
		_Toughness = 5;

            throw new NotImplementedException("Earth Elemental");
        }
        public Earth_Elemental(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
