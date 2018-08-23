using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Cursed_Land : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=53
            *  
            *  Enchant land
At the beginning of the upkeep of enchanted land's controller, Cursed Land deals 1 damage to that player.
            *  
            * Rulings

            *  
            */
        public Cursed_Land() : base()
        {
            MultiverseId = 53;
            Name = "Cursed Land";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Cursed Land");
        }
        public Cursed_Land(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
