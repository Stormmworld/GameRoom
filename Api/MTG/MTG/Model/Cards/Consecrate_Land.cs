using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Consecrate_Land : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=245
            *  
            *  Enchant land
Enchanted land has indestructible and can't be enchanted by other Auras.
            *  
            * Rulings
		2005-04-01: The land can be targeted by land-destroying spells and the spell will resolve, but the land will simply not be destroyed.
		2006-09-25: If Consecrate Land enters the battlefield attached to a land that's enchanted by other Auras, those Auras are put into their owners' graveyards.
		2013-07-01: A permanent with indestructible can't be destroyed, but it can still be sacrificed, exiled, put into a graveyard, and so on.

            *  
            */
        public Consecrate_Land() : base()
        {
            MultiverseId = 245;
            Name = "Consecrate Land";
	Add(Enumerations.Colors.White);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Consecrate Land");
        }
        public Consecrate_Land(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
