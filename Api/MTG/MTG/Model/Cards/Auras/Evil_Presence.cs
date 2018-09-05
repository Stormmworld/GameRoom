using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class Evil_Presence : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=63
        *  
        *  Enchant land
        *   Enchanted land is a Swamp.
        *  
        * Rulings
        * 2009-10-01: The enchanted land loses its existing land types and any abilities printed on it. It now has the land type Swamp and has the ability "{T}: Add {B} to your mana pool." Evil Presence doesn't change the enchanted land's name or whether it's legendary, basic, or snow.
        *
        */
        public Evil_Presence() :  base(new TargetCardRequirements() { HasType = CardType.Land, InZone = TargetZone.Battlefield })
        {
            MultiverseId = 63;
            Name = "Evil Presence";
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new EffectGeneratorTriggered(EffectTrigger.Aura_Attached, new TargetRequirements(TargetScope.Single, TargetType.Card), typeof(CardSubTypeModificationEffect)) { SubType = SubType.Swamp, BoolValue = true , BoundCardId = Id});
        }
        public Evil_Presence(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
