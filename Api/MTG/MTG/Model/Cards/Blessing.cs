using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Activated;
using System.Collections.Generic;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Counters;

namespace MTG.Model.Cards
{
    public class Blessing : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=238
        *  
        *  Enchant creature 
        *  {W}: Enchanted creature gets +1/+1 until end of turn.
        *  
        * Rulings
        *
        */
        public Blessing() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 238;
            Name = "Blessing";
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new CounterGenerator(false, new PlusXPlusY(1, 1) { },new CastingCost(new List<IManaCost>() { new ManaCost(new Mana(Color.White, 1)) })));
            throw new NotImplementedException("Blessing");
        }
        public Blessing(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
