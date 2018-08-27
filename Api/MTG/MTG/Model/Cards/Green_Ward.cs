using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Green_Ward : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=251
        *  
        *  Enchant creature
Enchanted creature has protection from green. This effect doesn't remove Green Ward.
        *  
        * Rulings

        *
        */
        public Green_Ward() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 251;
            Name = "Green Ward";
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Green Ward");
        }
        public Green_Ward(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
