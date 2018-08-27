using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Wanderlust : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=182
        *  
        *  Enchant creature
At the beginning of the upkeep of enchanted creature's controller, Wanderlust deals 1 damage to that player.
        *  
        * Rulings

        *
        */
        public Wanderlust() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 182;
            Name = "Wanderlust";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Wanderlust");
        }
        public Wanderlust(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
