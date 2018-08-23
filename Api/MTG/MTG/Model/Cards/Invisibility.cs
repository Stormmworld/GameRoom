using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Invisibility : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=107
            *  
            *  Enchant creature
Enchanted creature can't be blocked except by Walls.
            *  
            * Rulings

            *  
            */
        public Invisibility() : base()
        {
            MultiverseId = 107;
            Name = "Invisibility";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Invisibility");
        }
        public Invisibility(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
