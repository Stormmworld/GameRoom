using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Counters;

namespace MTG.Model.Cards
{
    public class Holy_Strength : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=255
        *  
        *  Enchant creature
        *  Enchanted creature gets +1/+2.
        *  
        * Rulings

        *
        */
        public Holy_Strength() :  base(new TargetCardRequirements() { HasType = CardType.Creature, InZone = TargetZone.Battlefield })
        {
            MultiverseId = 255;
            Name = "Holy Strength";
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new CounterGenerator(EffectTrigger.Aura_Attached, new TargetRequirements(TargetScope.Single, TargetType.EnchantedCard), new PlusXPlusY(1,2) { OwningCardId = Id}));
        }
        public Holy_Strength(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
