using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Blue_Elemental_Blast : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=97
        *  
        *  Choose one —
        • Counter target red spell.
        • Destroy target red permanent.
        *  
        * Rulings
        * 2004-10-04: The decision to counter a spell or destroy a permanent is a decision made on announcement before the target is selected. If the spell is redirected, this mode can't be changed, so only targets of the selected type are valid.

        *
        */
        public Blue_Elemental_Blast() : base()
        {
            MultiverseId = 97;
            Name = "Blue Elemental Blast";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(CardType.Instant);
            Add(new Abilities.Casting.CounterSpell(abilityCost, new TargetRequirements(TargetScope.Single, new List<TargetType>() { TargetType.Card }, new TargetCardRequirements() { HasColors = Color.Red, InZone = TargetZone.Stack }),false));
            Add(new Abilities.Casting.Destroy(abilityCost, new TargetRequirements(TargetScope.Single, new List<TargetType>() { TargetType.Card }, new TargetCardRequirements() { HasColors = Color.Red, InZone = TargetZone.Battlefield }), false));
        }
        public Blue_Elemental_Blast(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}