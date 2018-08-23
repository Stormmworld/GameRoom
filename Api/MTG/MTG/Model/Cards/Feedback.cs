using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Feedback : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=105
            *  
            *  Enchant enchantment
At the beginning of the upkeep of enchanted enchantment's controller, Feedback deals 1 damage to that player.
            *  
            * Rulings

            *  
            */
        public Feedback() : base()
        {
            MultiverseId = 105;
            Name = "Feedback";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Feedback");
        }
        public Feedback(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
