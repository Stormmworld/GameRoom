using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Static;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Animate_Wall : Aura
    {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=232
        *  
        *  Enchant Wall
        *   Enchanted Wall can attack as though it didn't have defender.
        *  
        * Rulings
        * 2007-09-16: This is a change from the most recent wording. As was the case in the past, Animate Wall can now enchant only a Wall.
        *
        */
        public Animate_Wall() : base(new TargetCardRequirements() { HasType = CardType.Creature, InZone = TargetZone.Battlefield, HasSubType = SubType.Wall })
        {
            MultiverseId = 232;
            Name = "Animate Wall";
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new RemoveAbility(EffectTrigger.Aura_Attached, new Defender()));
            Add(new AddAbility(EffectTrigger.Aura_Detached, new Defender()));
        }
        public Animate_Wall(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
