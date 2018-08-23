using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Thicket_Basilisk : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=174
            *  
            *  Whenever Thicket Basilisk blocks or becomes blocked by a non-Wall creature, destroy that creature at end of combat.
            *  
            * Rulings
		2004-10-04: Protection from Green does not stop the Basilisk's ability because the ability is not targeted.
		2004-10-04: The ability destroys the creature at the end of the combat, which is after all first strike and normal damage dealing is done. This means that a creature may have to regenerate twice to survive the combat, once from damage and once again at end of combat.

            *  
            */
        public Thicket_Basilisk() : base()
        {
            MultiverseId = 174;
            Name = "Thicket Basilisk";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Basilisk);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 4;

            throw new NotImplementedException("Thicket Basilisk");
        }
        public Thicket_Basilisk(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
