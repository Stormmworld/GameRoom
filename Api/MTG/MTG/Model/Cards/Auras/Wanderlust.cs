using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class Wanderlust : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=182
        *  
        *  Enchant creature
        *   At the beginning of the upkeep of enchanted creature's controller, Wanderlust deals 1 damage to that player.
        *  
        * Rulings
        *
        */
        public Wanderlust() :  base(new TargetCardRequirements() { HasType = CardType.Creature, InZone = TargetZone.Battlefield })
        {
            MultiverseId = 182;
            Name = "Wanderlust";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new EffectGeneratorTriggered(EffectTrigger.Phases_BegginingPhase_UpkeepStep, new TargetRequirements(TargetScope.Single, TargetType.EnchantedController), typeof(DamageEffect)) { Damage = new Damage(this, 1)});
        }
        public Wanderlust(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
