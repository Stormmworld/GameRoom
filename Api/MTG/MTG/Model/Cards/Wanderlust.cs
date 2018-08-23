using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Wanderlust : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=182
            *  
            *  Enchant creature
At the beginning of the upkeep of enchanted creature's controller, Wanderlust deals 1 damage to that player.
            *  
            * Rulings

            *  
            */
        public Wanderlust() : base()
        {
            MultiverseId = 182;
            Name = "Wanderlust";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Wanderlust");
        }
        public Wanderlust(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
