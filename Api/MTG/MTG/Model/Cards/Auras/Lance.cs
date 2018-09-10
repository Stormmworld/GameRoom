using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class Lance : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=258
        *  
        *  Enchant creature
        *  Enchanted creature has first strike.
        *  
        * Rulings

        *
        */
        public Lance() : base(new TargetCardRequirements() { HasType = CardType.Creature, InZone = TargetZone.Battlefield });
        {
            MultiverseId = 258;
            Name = "Lance";
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new AddAbility(EffectTrigger.Aura_Attached, new First_Strike() { BoundCardId = Id}));
        }
        public Lance(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
