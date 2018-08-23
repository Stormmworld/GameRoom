using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Llanowar_Elves : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=166
            *  
            *  {T}: Add {G} to your mana pool.
            *  
            * Rulings

            *  
            */
        public Llanowar_Elves() : base()
        {
            MultiverseId = 166;
            Name = "Llanowar Elves";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Elf);
	Add(Enumerations.SubType.Druid);
	Add(Enumerations.CardType.Creature);
	_Power = 1;
		_Toughness = 1;

            throw new NotImplementedException("Llanowar Elves");
        }
        public Llanowar_Elves(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
