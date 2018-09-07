using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Activated;
using MTG.Model.Data_Objects;
using MTG.Interfaces.Mana_Interfaces;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Jade_Monolith : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=23
        *  
        *  {1}: The next time a source of your choice would deal damage to target creature this turn, that source deals that damage to you instead.
        *  
        * Rulings
        *
        */
        public Jade_Monolith() : base()
        {
            MultiverseId = 23;
            Name = "Jade Monolith";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            Add(CardType.Artifact);
            TargetRequirements newTargetRequirements = new TargetRequirements(TargetScope.Owner, TargetType.Player);
            TargetRequirements originalTargetRequirements = new TargetRequirements(TargetScope.Single, TargetType.Card, new TargetCardRequirements() { HasType = CardType.Creature, InZone = TargetZone.Battlefield});
            List<IManaCost> activationCost = new List<IManaCost>() { new ManaCost(new Mana( Color.Colorless, 1))};
            Add(new TargetModifierActivated(false, activationCost, originalTargetRequirements, newTargetRequirements));
        }
        public Jade_Monolith(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
