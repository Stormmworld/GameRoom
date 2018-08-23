using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Scavenging_Ghoul : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=82
            *  
            *  At the beginning of each end step, put a corpse counter on Scavenging Ghoul for each creature that died this turn.
Remove a corpse counter from Scavenging Ghoul: Regenerate Scavenging Ghoul.
            *  
            * Rulings
		2004-10-04: The Ghoul still gets to claim counters even if it enters the battlefield after the creatures died.

            *  
            */
        public Scavenging_Ghoul() : base()
        {
            MultiverseId = 82;
            Name = "Scavenging Ghoul";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Zombie);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 2;

            throw new NotImplementedException("Scavenging Ghoul");
        }
        public Scavenging_Ghoul(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
