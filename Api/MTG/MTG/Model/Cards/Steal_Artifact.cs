using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Steal_Artifact : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=129
        *  
        *  Enchant artifact
You control enchanted artifact.
        *  
        * Rulings
        * 2004-10-04: Can be used on artifact creatures.

        *
        */
        public Steal_Artifact() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 129;
            Name = "Steal Artifact";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Steal Artifact");
        }
        public Steal_Artifact(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
