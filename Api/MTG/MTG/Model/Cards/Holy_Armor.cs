using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Holy_Armor : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=254
        *  
        *  Enchant creature
Enchanted creature gets +0/+2.
{W}: Enchanted creature gets +0/+1 until end of turn.
        *  
        * Rulings

        *
        */
        public Holy_Armor() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 254;
            Name = "Holy Armor";
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Holy Armor");
        }
        public Holy_Armor(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
