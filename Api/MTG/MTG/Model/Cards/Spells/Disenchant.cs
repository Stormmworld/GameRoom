using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Data_Objects;
using System.Collections.Generic;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class Disenchant : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=249
        *  
        *  Destroy target artifact or enchantment.
        *  
        * Rulings
        * 2004-10-04: This is not modal. If the target changes from an artifact to an enchantment or vice versa, this still destroys it.
        *
        */
        public Disenchant() : base()
        {
            MultiverseId = 249;
            Name = "Disenchant";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            abilityCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Instant);
            Add(new CreateEffect(abilityCost, new TargetRequirements( TargetScope.Single,  TargetType.Card , new TargetCardRequirements() { HasType = CardType.Artifact , InZone = TargetZone.Battlefield}),typeof(DestroyEffect),false));
            Add(new CreateEffect(abilityCost, new TargetRequirements(TargetScope.Single,  TargetType.Card , new TargetCardRequirements() { HasType = CardType.Enchantment, InZone = TargetZone.Battlefield }), typeof(DestroyEffect), false));
        }
        public Disenchant(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
