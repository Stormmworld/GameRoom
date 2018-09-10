using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Static;
using MTG.Model.Counters;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Lord_of_Atlantis : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=110
        *  
        *  Other Merfolk creatures get +1/+1 and have islandwalk. (They can't be blocked as long as defending player controls an Island.)
        *  
        * Rulings
        *
        */
        public Lord_of_Atlantis() : base()
        {
            MultiverseId = 110;
            Name = "Lord of Atlantis";
            Set(2, 2);
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Merfolk);
            Add(CardType.Creature);
            Add(new CounterGeneratorStatic(new PlusXPlusY(1, 1) {OwningCardId = Id}, new TargetRequirements(TargetScope.All, TargetType.Card, new TargetCardRequirements() { HasType = CardType.Creature, HasSubType= SubType.Merfolk, InZone = TargetZone.Battlefield})));
            Add(new AbilityGeneratorStatic(new Landwalk(SubType.Island) { BoundCardId = Id}, new TargetRequirements(TargetScope.All, TargetType.Card, new TargetCardRequirements() { HasType = CardType.Creature, HasSubType = SubType.Merfolk, InZone = TargetZone.Battlefield })));
        }
        public Lord_of_Atlantis(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
