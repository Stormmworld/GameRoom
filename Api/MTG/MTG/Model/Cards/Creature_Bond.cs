using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Creature_Bond : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=103
            *  
            *  Enchant creature
When enchanted creature dies, Creature Bond deals damage equal to that creature's toughness to the creature's controller.
            *  
            * Rulings

            *  
            */
        public Creature_Bond() : base()
        {
            MultiverseId = 103;
            Name = "Creature Bond";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Creature Bond");
        }
        public Creature_Bond(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
