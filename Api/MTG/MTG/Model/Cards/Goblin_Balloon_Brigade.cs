using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Goblin_Balloon_Brigade : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=201
            *  
            *  {R}: Goblin Balloon Brigade gains flying until end of turn.
            *  
            * Rulings
		2008-08-01: You can activate the ability repeatedly during a turn. This generally has no additional effect, unless some other effect (like that from Adarkar Windform has caused it to lose flying since the last time the ability resolved.
		2010-08-15: For flying to work as an evasion ability, an attacking Goblin Balloon Brigade's ability must be activated before the declare blockers step begins. Once Goblin Balloon Brigade has become blocked, giving it flying won't change that.

            *  
            */
        public Goblin_Balloon_Brigade() : base()
        {
            MultiverseId = 201;
            Name = "Goblin Balloon Brigade";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Goblin);
	Add(Enumerations.SubType.Warrior);
	Add(Enumerations.CardType.Creature);
	_Power = 1;
		_Toughness = 1;

            throw new NotImplementedException("Goblin Balloon Brigade");
        }
        public Goblin_Balloon_Brigade(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
