using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Wild_Growth : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=185
        *  
        *  Enchant land
Whenever enchanted land is tapped for mana, its controller adds {G} to his or her mana pool (in addition to the mana the land produces).
        *  
        * Rulings
        * 2004-10-04: The additional mana is not an ability of the land and is not something the land can produce.

        *
        */
        public Wild_Growth() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 185;
            Name = "Wild Growth";
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Wild Growth");
        }
        public Wild_Growth(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
