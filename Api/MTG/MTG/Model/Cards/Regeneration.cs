using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Regeneration : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=169
        *  
        *  Enchant creature (Target a creature as you cast this. This card enters the battlefield attached to that creature.)
{G}: Regenerate enchanted creature. (The next time that creature would be destroyed this turn, it isn't. Instead tap it, remove all damage from it, and remove it from combat.)
        *  
        * Rulings

        *
        */
        public Regeneration() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 169;
            Name = "Regeneration";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Regeneration");
        }
        public Regeneration(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
