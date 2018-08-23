using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Timber_Wolves : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=175
            *  
            *  Banding (Any creatures with banding, and up to one without, can attack in a band. Bands are blocked as a group. If any creatures with banding you control are blocking or being blocked by a creature, you divide that creature's combat damage, not its controller, among any of the creatures it's being blocked by or is blocking.)
            *  
            * Rulings
		2008-10-01: If a creature with banding attacks, it can team up with any number of other attacking creatures with banding (and up to one nonbanding creature) and attack as a unit called a "band." The band can be blocked by any creature that could block a single creature in the band. Blocking any creature in a band blocks the entire band. If a creature with banding is blocked, the attacking player chooses how the blockers' damage is assigned.
		2008-10-01: A maximum of one nonbanding creature can join an attacking band no matter how many creatures with banding are in it.
		2008-10-01: Creatures in the same band must all attack the same player or planeswalker.
		2009-10-01: If a creature in combat has banding, its controller assigns damage for creatures blocking or blocked by it. That player can ignore the damage assignment order when making this assignment.

            *  
            */
        public Timber_Wolves() : base()
        {
            MultiverseId = 175;
            Name = "Timber Wolves";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Wolf);
	Add(Enumerations.CardType.Creature);
	_Power = 1;
		_Toughness = 1;

            throw new NotImplementedException("Timber Wolves");
        }
        public Timber_Wolves(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
