using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Abilities.Static;
using MTG.Model.Effects;
using MTG.Model.Data_Objects;
using MTG.Model.Counters;

namespace MTG.Model.Cards
{
    public class Gauntlet_of_Might : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=15
        *  
        *  Red creatures get +1/+1.
        *   Whenever a Mountain is tapped for mana, its controller adds {R} to his or her mana pool (in addition to the mana the land produces).
        *  
        * Rulings
        * 2004-10-04: Dual lands which have Mountain as one of their types produce an extra red mana when tapped for either color.
        *
        */
        #region Constructors
        public Gauntlet_of_Might() : base()
        {
            MultiverseId = 15;
            Name = "Gauntlet of Might";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            Add(CardType.Artifact);
            Add(new EffectGeneratorStatic(typeof(ExtraManaEffect), new TargetRequirements(TargetScope.All, TargetType.Card, new TargetCardRequirements() { HasSubType = SubType.Mountain, InZone = TargetZone.Battlefield })));
            Add(new CounterGeneratorStatic(new PlusXPlusY(1, 1) { OwningCardId = Id}, new TargetRequirements(TargetScope.All, TargetType.Card, new TargetCardRequirements() { HasColor = Color.Red, InZone = TargetZone.Battlefield })));
        }
        public Gauntlet_of_Might(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
        #endregion
    }
}
