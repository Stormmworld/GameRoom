using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Ley_Druid : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=161
            *  
            *  {T}: Untap target land.
            *  
            * Rulings
		2004-10-04: The land is untapped as a normal ability that goes on the stack. It is not a mana ability, so it can't be used at times that only mana abilities can be used.

            *  
            */
        public Ley_Druid() : base()
        {
            MultiverseId = 161;
            Name = "Ley Druid";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Human);
	Add(Enumerations.SubType.Druid);
	Add(Enumerations.CardType.Creature);
	_Power = 1;
		_Toughness = 1;

            throw new NotImplementedException("Ley Druid");
        }
        public Ley_Druid(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
