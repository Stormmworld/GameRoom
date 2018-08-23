using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Elvish_Archers : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=147
            *  
            *  First strike
            *  
            * Rulings

            *  
            */
        public Elvish_Archers() : base()
        {
            MultiverseId = 147;
            Name = "Elvish Archers";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Elf);
	Add(Enumerations.SubType.Archer);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 1;

            throw new NotImplementedException("Elvish Archers");
        }
        public Elvish_Archers(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
