using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class Burrowing : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=186
        *  
        *  Enchant creature
        *   Enchanted creature has mountainwalk. (It can't be blocked as long as defending player controls a Mountain.)
        *  
        * Rulings
        *
        */
        public Burrowing() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 186;
            Name = "Burrowing";
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new AddAbility(EffectTrigger.Aura_Attached, new Landwalk(SubType.Mountain) { BoundCardId = Id }));
            Add(new RemoveAbility(EffectTrigger.Aura_Detached, new Landwalk(SubType.Mountain) { BoundCardId = Id }));
        }
        public Burrowing(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
