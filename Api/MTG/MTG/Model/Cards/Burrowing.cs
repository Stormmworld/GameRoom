using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Burrowing : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=186
        *  
        *  Enchant creature
Enchanted creature has mountainwalk. (It can't be blocked as long as defending player controls a Mountain.)
        *  
        * Rulings

        *
        */
        public Burrowing() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 186;
            Name = "Burrowing";
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Burrowing");
        }
        public Burrowing(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
