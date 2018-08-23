using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Sengir_Vampire : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=83
            *  
            *  Flying (This creature can't be blocked except by creatures with flying or reach.)
Whenever a creature dealt damage by Sengir Vampire this turn dies, put a +1/+1 counter on Sengir Vampire.
            *  
            * Rulings
		2007-07-15: If Sengir Vampire deals nonlethal damage to a creature and then a different effect or damage source causes that creature to be put into a graveyard later in the turn, Sengir Vampire's ability will trigger and it will get a +1/+1 counter.
		2011-09-22: Each time a creature is put into a graveyard from the battlefield, check whether Sengir Vampire had dealt any damage to it at any time during that turn. If so, Sengir Vampire's ability will trigger. It doesn't matter who controlled the creature or whose graveyard it was put into.
		2011-09-22: If Sengir Vampire and a creature it dealt damage to are both put into a graveyard at the same time, Sengir Vampire's ability will trigger, but it will do nothing when it resolves.

            *  
            */
        public Sengir_Vampire() : base()
        {
            MultiverseId = 83;
            Name = "Sengir Vampire";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Vampire);
	Add(Enumerations.CardType.Creature);
	_Power = 4;
		_Toughness = 4;

            throw new NotImplementedException("Sengir Vampire");
        }
        public Sengir_Vampire(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
