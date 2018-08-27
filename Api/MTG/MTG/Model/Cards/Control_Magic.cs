using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Control_Magic : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=100
        *  
        *  Enchant creature
You control enchanted creature.
        *  
        * Rulings
        * 2016-06-08: Gaining control of a creature doesn't cause you to gain control of any Auras or Equipment attached to it.

        *
        */
        public Control_Magic() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 100;
            Name = "Control Magic";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Control Magic");
        }
        public Control_Magic(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
