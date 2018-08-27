using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Triggered;
using System.Collections.Generic;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Animate_Artifact : Aura
    {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=96
        *  
        *  Enchant artifact
        *  As long as enchanted artifact isn't a creature, it's an artifact creature with power and toughness each equal to its converted mana cost.
        *  
        * Rulings
        * 2008-08-01: This card has been returned to its original functionality. If it is enchanting an artifact that's already a creature, it won't change its power and toughness.
        * 2008-08-01: A noncreature permanent that turns into a creature can attack, and its {T} abilities can be activated, only if its controller has continuously controlled that permanent since the beginning of his or her most recent turn. It doesn't matter how long the permanent has been a creature.
        *
        */
        public Animate_Artifact() : base(new TargetCardRequirements() { HasType = CardType.Artifact, InZone = TargetZone.Battlefield })
        {
            MultiverseId = 96;
            Name = "Animate Artifact";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1))); ;
            Add(Color.Blue);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new ConvertToCreature(EffectTrigger.Aura_Attached, ConversionModifier.ConvertedCost, ConversionModifier.ConvertedCost));
        }
        public Animate_Artifact(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
