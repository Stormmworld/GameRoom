using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Unholy_Strength : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=87
        *  
        *  Enchant creature
Enchanted creature gets +2/+1.
        *  
        * Rulings

        *
        */
        public Unholy_Strength() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 87;
            Name = "Unholy Strength";
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Unholy Strength");
        }
        public Unholy_Strength(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
