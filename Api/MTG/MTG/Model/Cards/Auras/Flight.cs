using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Static;
using MTG.Model.Abilities.Triggered;

namespace MTG.Model.Cards
{
    public class Flight : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=106
        *  
        *  Enchant creature
        *  Enchanted creature has flying.
        *  
        * Rulings
        *
        */
        public Flight() :  base(new TargetCardRequirements() { HasType = CardType.Creature, InZone = TargetZone.Battlefield })
        {
            MultiverseId = 106;
            Name = "Flight";
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new AddAbility(EffectTrigger.Aura_Detached, new Flying() { BoundCardId = Id }));
            Add(new RemoveAbility(EffectTrigger.Aura_Detached, new Flying() { BoundCardId = Id }));
        }
        public Flight(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
