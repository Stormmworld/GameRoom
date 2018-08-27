using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Warp_Artifact : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=89
        *  
        *  Enchant artifact
At the beginning of the upkeep of enchanted artifact's controller, Warp Artifact deals 1 damage to that player.
        *  
        * Rulings

        *
        */
        public Warp_Artifact() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 89;
            Name = "Warp Artifact";
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Warp Artifact");
        }
        public Warp_Artifact(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
