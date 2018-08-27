using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Feedback : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=105
        *  
        *  Enchant enchantment
At the beginning of the upkeep of enchanted enchantment's controller, Feedback deals 1 damage to that player.
        *  
        * Rulings

        *
        */
        public Feedback() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 105;
            Name = "Feedback";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Feedback");
        }
        public Feedback(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
