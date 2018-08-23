using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Dwarven_Warriors : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=191
            *  
            *  {T}: Target creature with power 2 or less can't be blocked this turn.
            *  
            * Rulings
		2004-10-04: The ability can be activated after a creature is blocked, but it has no effect. Once a creature is blocked, it can't be unblocked.
		2004-10-04: If you increase the power of the targeted creature after the ability resolves, it still can't be blocked that turn.

            *  
            */
        public Dwarven_Warriors() : base()
        {
            MultiverseId = 191;
            Name = "Dwarven Warriors";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Dwarf);
	Add(Enumerations.SubType.Warrior);
	Add(Enumerations.CardType.Creature);
	_Power = 1;
		_Toughness = 1;

            throw new NotImplementedException("Dwarven Warriors");
        }
        public Dwarven_Warriors(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
