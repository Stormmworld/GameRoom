using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Blue_Ward : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=239
        *  
        *  Enchant creature
Enchanted creature has protection from blue. This effect doesn't remove Blue Ward.
        *  
        * Rulings

        *
        */
        public Blue_Ward() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 239;
            Name = "Blue Ward";
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Blue Ward");
        }
        public Blue_Ward(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
