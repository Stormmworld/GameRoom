using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Counters;

namespace MTG.Model.Cards
{
    public class Aspect_of_Wolf : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=140
        *  
        *  Enchant creature
        *   Enchanted creature gets +X/+Y, where X is half the number of Forests you control, rounded down, and Y is half the number of Forests you control, rounded up.
        *  
        * Rulings
        * 2009-10-01: The effect is continuously updated based on the number of Forests you control at any given time.

        *
        */
        public Aspect_of_Wolf() :  base(new TargetCardRequirements() {HasType= CardType.Creature,InZone= TargetZone.Battlefield })
        {
            MultiverseId = 140;
            Name = "Aspect of Wolf";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new CounterGenerator(EffectTrigger.LandEntersBattlefield, new TargetRequirements(TargetScope.Single, TargetType.Creature), new PlusXPlusY(Incrementer.Half_ControlledForests_RoundedDown, Incrementer.Half_ControlledForests_RoundedUp)));
            Add(new CounterGenerator(EffectTrigger.Aura_Attached, new TargetRequirements(TargetScope.Single,  TargetType.Creature), new PlusXPlusY(Incrementer.Half_ControlledForests_RoundedDown, Incrementer.Half_ControlledForests_RoundedUp)));
        }
        public Aspect_of_Wolf(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
