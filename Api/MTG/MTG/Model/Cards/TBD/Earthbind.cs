using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class Earthbind : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=193
        *  
        *  Enchant creature
When Earthbind enters the battlefield, if enchanted creature has flying, Earthbind deals 2 damage to that creature and Earthbind gains "Enchanted creature loses flying."
        *  
        * Rulings
        * 2004-10-04: If the enchanted creature gains flying after Earthbind is put onto it, it will have flying. The two effects are simply applied in timestamp order.

        *
        */
        public Earthbind() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 193;
            Name = "Earthbind";
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Earthbind");
        }
        public Earthbind(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
