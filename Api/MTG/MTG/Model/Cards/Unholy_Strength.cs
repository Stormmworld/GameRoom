using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Unholy_Strength : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=87
            *  
            *  Enchant creature
Enchanted creature gets +2/+1.
            *  
            * Rulings

            *  
            */
        public Unholy_Strength() : base()
        {
            MultiverseId = 87;
            Name = "Unholy Strength";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Unholy Strength");
        }
        public Unholy_Strength(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
