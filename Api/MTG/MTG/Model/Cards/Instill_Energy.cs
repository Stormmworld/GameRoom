using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Instill_Energy : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=158
            *  
            *  Enchant creature
Enchanted creature can attack as though it had haste.
{0}: Untap enchanted creature. Activate this ability only during your turn and only once each turn.
            *  
            * Rulings
		2004-10-04: If attached to an opponent's creature, you can untap their creature during your turn.
		2004-10-04: Instill Energy's untap ability will not untap the creature until it resolves. This means other spells and abilities can be used before it actually becomes untapped.
		2005-08-01: Any Auras (or other effects) which are on the creature that would cause it to not be untapped (or have a cost to be untapped) during untap step do not in any way hinder or imply a cost to use this card's ability to untap once during the turn.

            *  
            */
        public Instill_Energy() : base()
        {
            MultiverseId = 158;
            Name = "Instill Energy";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Instill Energy");
        }
        public Instill_Energy(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
