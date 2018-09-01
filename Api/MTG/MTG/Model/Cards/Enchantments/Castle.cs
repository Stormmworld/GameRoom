using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Data_Objects;
using System.Collections.Generic;
using MTG.Model.Counters;

namespace MTG.Model.Cards
{
    public class Castle : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=240
        *  
        *  Untapped creatures you control get +0/+2.
        *  
        * Rulings

        *
        */
        public Castle() : base()
        {
            MultiverseId = 240;
            Name = "Castle";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Enchantment);
            Add(new CounterGenerator(EffectTrigger.Card_Untapped, new TargetRequirements(TargetScope.All,  TargetType.Creature, new TargetCardRequirements() { Tapped = true, HasType = CardType.Creature, InZone= TargetZone.Battlefield }), new PlusXPlusY(2, 0) { OwningCardId = Id}));
            Add(new CounterGenerator(EffectTrigger.Card_Tapped, new TargetRequirements(TargetScope.All,  TargetType.Creature , new TargetCardRequirements() { Tapped = true, HasType = CardType.Creature, InZone = TargetZone.Battlefield }), new PlusXPlusY(2, 0) { OwningCardId = Id }));
            Add(new CounterGenerator(EffectTrigger.Card_EntersBattleField, new TargetRequirements(TargetScope.All, TargetType.Creature , new TargetCardRequirements() { Tapped = true, HasType = CardType.Creature, InZone = TargetZone.Battlefield }), new PlusXPlusY(2, 0) { OwningCardId = Id }));
        }
        public Castle(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
