using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Flight : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=106
        *  
        *  Enchant creature
Enchanted creature has flying.
        *  
        * Rulings

        *
        */
        public Flight() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 106;
            Name = "Flight";
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Flight");
        }
        public Flight(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
