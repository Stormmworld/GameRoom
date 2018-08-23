using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Psychic_Venom : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=123
            *  
            *  Enchant land
Whenever enchanted land becomes tapped, Psychic Venom deals 2 damage to that land's controller.
            *  
            * Rulings
		2004-10-04: Whenever the land is tapped for any reason, the ability triggers.

            *  
            */
        public Psychic_Venom() : base()
        {
            MultiverseId = 123;
            Name = "Psychic Venom";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Psychic Venom");
        }
        public Psychic_Venom(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
