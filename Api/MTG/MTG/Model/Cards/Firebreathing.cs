using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Firebreathing : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=198
            *  
            *  Enchant creature
{R}: Enchanted creature gets +1/+0 until end of turn.
            *  
            * Rulings
		2009-10-01: This ability can be activated by Firebreathing's controller, not the enchanted creature's controller (in case they're different players).
		2009-10-01: The ability affects whichever creature is enchanted by Firebreathing at the time the ability resolves. The bonus remains even if Firebreathing stops enchanting that creature.

            *  
            */
        public Firebreathing() : base()
        {
            MultiverseId = 198;
            Name = "Firebreathing";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Firebreathing");
        }
        public Firebreathing(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
