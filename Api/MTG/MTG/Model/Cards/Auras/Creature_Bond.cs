using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Triggered;

namespace MTG.Model.Cards
{
    public class Creature_Bond : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=103
        *  
        *  Enchant creature
        *  When enchanted creature dies, Creature Bond deals damage equal to that creature's toughness to the creature's controller.
        *  
        * Rulings
        *
        */
        public Creature_Bond() :  base(new TargetCardRequirements() { HasType = CardType.Creature, InZone = TargetZone.Battlefield })
        {
            MultiverseId = 103;
            Name = "Creature Bond";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new TriggeredDamage(EffectTrigger.Card_Destroyed, new TargetRequirements(TargetScope.Single,  TargetType.Player ), new Damage(this, Modifier.Toughness)));
        }
        public Creature_Bond(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
