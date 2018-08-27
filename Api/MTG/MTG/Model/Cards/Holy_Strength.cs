using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Holy_Strength : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=255
        *  
        *  Enchant creature
Enchanted creature gets +1/+2.
        *  
        * Rulings

        *
        */
        public Holy_Strength() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 255;
            Name = "Holy Strength";
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Holy Strength");
        }
        public Holy_Strength(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
