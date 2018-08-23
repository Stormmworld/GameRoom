using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Paralyze : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=75
            *  
            *  Enchant creature
When Paralyze enters the battlefield, tap enchanted creature.
Enchanted creature doesn't untap during its controller's untap step.
At the beginning of the upkeep of enchanted creature's controller, that player may pay {4}. If he or she does, untap the creature.
            *  
            * Rulings
		2004-10-04: Paying the cost is optional.
		2004-10-04: Paralyze can be cast targeting a creature which is already tapped.
		2004-10-04: The creature can only be untapped using Paralyze once per turn.
		2004-10-04: Two Paralyzes are not cumulative. Paying either one will untap the creature.
		2007-09-16: This is a change from the most recent wording. As was the case in the past, Paralyze itself has the last triggered ability, rather than granting that ability to the enchanted creature.

            *  
            */
        public Paralyze() : base()
        {
            MultiverseId = 75;
            Name = "Paralyze";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Paralyze");
        }
        public Paralyze(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
