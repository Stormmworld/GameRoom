using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Weakness : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=90
        *  
        *  Enchant creature
Enchanted creature gets -2/-1.
        *  
        * Rulings

        *
        */
        public Weakness() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 90;
            Name = "Weakness";
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Weakness");
        }
        public Weakness(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
