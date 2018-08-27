using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Living_Artifact : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=164
        *  
        *  Enchant artifact
Whenever you're dealt damage, put that many vitality counters on Living Artifact.
At the beginning of your upkeep, you may remove a vitality counter from Living Artifact. If you do, you gain 1 life.
        *  
        * Rulings
        * 2004-10-04: You can cast it targeting your opponent's artifacts. The controller of the Aura (not the controller of the artifact) controls the Living Artifact ability.
        * 2004-10-04: Does not trigger on loss of life, just on damage.

        *
        */
        public Living_Artifact() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 164;
            Name = "Living Artifact";
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Living Artifact");
        }
        public Living_Artifact(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
