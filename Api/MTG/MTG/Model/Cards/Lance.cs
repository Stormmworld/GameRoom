using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Lance : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=258
        *  
        *  Enchant creature
Enchanted creature has first strike.
        *  
        * Rulings

        *
        */
        public Lance() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 258;
            Name = "Lance";
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Lance");
        }
        public Lance(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
