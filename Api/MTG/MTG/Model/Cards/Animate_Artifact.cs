using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Animate_Artifact : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=96
            *  
            *  Enchant artifact
As long as enchanted artifact isn't a creature, it's an artifact creature with power and toughness each equal to its converted mana cost.
            *  
            * Rulings
		2008-08-01: This card has been returned to its original functionality. If it is enchanting an artifact that's already a creature, it won't change its power and toughness.
		2008-08-01: A noncreature permanent that turns into a creature can attack, and its {T} abilities can be activated, only if its controller has continuously controlled that permanent since the beginning of his or her most recent turn. It doesn't matter how long the permanent has been a creature.

            *  
            */
        public Animate_Artifact() : base()
        {
            MultiverseId = 96;
            Name = "Animate Artifact";
            Add(Enumerations.Colors.Blue);
            Add(Enumerations.SubType.Aura);
            Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Animate Artifact");
        }
        public Animate_Artifact(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
