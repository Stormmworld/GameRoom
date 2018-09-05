using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Abilities.Activated;
using System.Collections.Generic;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Data_Objects;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class Disrupting_Scepter : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=13
        *  
        *  {3}, {T}: Target player discards a card. Activate this ability only during your turn.
        *  
        * Rulings
        * 2004-10-04: You can use it on yourself.
        *
        */
        public Disrupting_Scepter() : base()
        {
            MultiverseId = 13;
            Name = "Disrupting Scepter";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            Add(CardType.Artifact);
            Add(new EffectGenerator(true, new List<IManaCost>() { new ManaCost(new Mana(Color.Colorless, 3)) }, typeof(DiscardEffect), new TargetRequirements(TargetScope.Single,  TargetType.Player ), false) { EffectValue = 1});
        }
        public Disrupting_Scepter(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
