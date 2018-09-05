using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Static;
using MTG.Model.Abilities.Triggered;

namespace MTG.Model.Cards
{
    public class Fear : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=64
        *  
        *  Enchant creature (Target a creature as you cast this. This card enters the battlefield attached to that creature.)
        *  Enchanted creature has fear. (It can't be blocked except by artifact creatures and/or black creatures.)
        *  
        * Rulings

        *
        */
        public Fear() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 64;
            Name = "Fear";
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new AddAbility(EffectTrigger.Aura_Detached, new FearAbility() { BoundCardId = Id }));
            Add(new RemoveAbility(EffectTrigger.Aura_Detached, new FearAbility() { BoundCardId = Id }));
        }
        public Fear(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
