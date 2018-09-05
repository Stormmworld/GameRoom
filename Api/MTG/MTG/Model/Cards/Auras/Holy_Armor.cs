using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Counters;
using MTG.Interfaces.Mana_Interfaces;

namespace MTG.Model.Cards
{
    public class Holy_Armor : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=254
        *  
        *  Enchant creature
        *   Enchanted creature gets +0/+2.
        *   {W}: Enchanted creature gets +0/+1 until end of turn.
        *  
        * Rulings
        *
        */
        public Holy_Armor() :  base(new TargetCardRequirements() { HasType = CardType.Creature, InZone = TargetZone.Battlefield })
        {
            MultiverseId = 254;
            Name = "Holy Armor";
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new Abilities.Triggered.CounterGenerator(EffectTrigger.Card_EntersBattleField, new TargetRequirements(TargetScope.Self, TargetType.Card), new PlusXPlusY(0, 2) { OwningCardId = Id }));
            Add(new Abilities.Activated.CounterGenerator(false, new List<IManaCost>() { new ManaCost(new Mana(Color.White, 1))}, new PlusXPlusY(0, 2) { RemoveAtEndOfTurn = true }));
        }
        public Holy_Armor(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
