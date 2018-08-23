using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Power_Leak : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=119
            *  
            *  Enchant enchantment
At the beginning of the upkeep of enchanted enchantment's controller, that player may pay any amount of mana. Power Leak deals 2 damage to that player. Prevent X of that damage, where X is the amount of mana that player paid this way.
            *  
            * Rulings

            *  
            */
        public Power_Leak() : base()
        {
            MultiverseId = 119;
            Name = "Power Leak";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Power Leak");
        }
        public Power_Leak(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
