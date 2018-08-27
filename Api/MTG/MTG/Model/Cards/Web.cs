using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Web : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=184
        *  
        *  Enchant creature (Target a creature as you cast this. This card enters the battlefield attached to that creature.)
Enchanted creature gets +0/+2 and has reach. (It can block creatures with flying.)
        *  
        * Rulings

        *
        */
        public Web() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 184;
            Name = "Web";
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Web");
        }
        public Web(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
