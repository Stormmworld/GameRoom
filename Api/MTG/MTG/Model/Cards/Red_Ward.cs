using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Red_Ward : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=264
        *  
        *  Enchant creature
Enchanted creature has protection from red. This effect doesn't remove Red Ward.
        *  
        * Rulings

        *
        */
        public Red_Ward() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 264;
            Name = "Red Ward";
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Red Ward");
        }
        public Red_Ward(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
