using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Farmstead : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=250
        *  
        *  Enchant land
Enchanted land has "At the beginning of your upkeep, you may pay {W}{W}. If you do, you gain 1 life."
        *  
        * Rulings

        *
        */
        public Farmstead() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 250;
            Name = "Farmstead";
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Farmstead");
        }
        public Farmstead(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
