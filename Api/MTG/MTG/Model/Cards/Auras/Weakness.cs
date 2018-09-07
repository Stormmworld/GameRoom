using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Counters;

namespace MTG.Model.Cards
{
    public class Weakness : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=90
        *  
        *  Enchant creature
        *  Enchanted creature gets -2/-1.
        *  
        * Rulings
        *
        */
        public Weakness() :  base(new TargetCardRequirements() {HasType = CardType.Creature, InZone= TargetZone.Battlefield })
        {
            MultiverseId = 90;
            Name = "Weakness";
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new CounterGenerator(EffectTrigger.LandEntersBattlefield, new TargetRequirements(TargetScope.Single, TargetType.Card), new PlusXPlusY(Incrementer.Half_ControlledForests_RoundedDown, Incrementer.Half_ControlledForests_RoundedUp){ OwningCardId = Id}));
        }
        public Weakness(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}