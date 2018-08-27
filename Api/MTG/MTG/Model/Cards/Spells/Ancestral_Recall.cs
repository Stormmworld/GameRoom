using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using System.Collections.Generic;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Ancestral_Recall : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=95
        *  
        *  Target player draws three cards.
        *  
        * Rulings
        *
        */
        public Ancestral_Recall() : base()
        {
            MultiverseId = 95;
            Name = "Ancestral Recall";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(CardType.Instant);
            Add(new DrawCards(3, abilityCost, new TargetRequirements(TargetScope.Single, new List<TargetType>() { TargetType.Player}), false));
        }
        public Ancestral_Recall(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
