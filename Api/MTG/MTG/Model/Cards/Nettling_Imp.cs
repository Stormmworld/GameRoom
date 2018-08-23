using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Nettling_Imp : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=73
            *  
            *  {T}: Choose target non-Wall creature the active player has controlled continuously since the beginning of the turn. That creature attacks this turn if able. Destroy it at the beginning of the next end step if it didn't attack this turn. Activate this ability only during an opponent's turn, before attackers are declared.
            *  
            * Rulings
		2004-10-04: If the Imp leaves the battlefield before the end of the turn, the creature still is destroyed.
		2004-10-04: You can use this effect on a creature you know won't be able to attack. For example, you can use it on a tapped creature.
		2004-10-04: The creature is destroyed if it does not attack because it simply can't do so legally.
		2013-09-20: If a turn has multiple combat phases, the ability can only be activated before the beginning of the declare attackers step of the first combat phase in that turn.

            *  
            */
        public Nettling_Imp() : base()
        {
            MultiverseId = 73;
            Name = "Nettling Imp";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Imp);
	Add(Enumerations.CardType.Creature);
	_Power = 1;
		_Toughness = 1;

            throw new NotImplementedException("Nettling Imp");
        }
        public Nettling_Imp(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
