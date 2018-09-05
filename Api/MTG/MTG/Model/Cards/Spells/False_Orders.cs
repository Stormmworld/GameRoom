using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Data_Objects;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class False_Orders : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=195
        *  
        *  Cast False Orders only during the declare blockers step.
        *  Remove target creature defending player controls from combat. Creatures it was blocking that had become blocked by only that creature this combat become unblocked. You may have it block an attacking creature of your choice.
        *  
        * Rulings
        * 2004-10-04: If a creature is removed from being a blocker of a given attacker, any triggered abilities that would have happened because it was declared as a blocker still happen.
        *
        */
        public False_Orders() : base()
        {
            MultiverseId = 195;
            Name = "False Orders";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Instant);
            Add(new CreateEffect(abilityCost, new TargetRequirements(TargetScope.Single, TargetType.Card, new TargetCardRequirements() { HasType= CardType.Creature, InZone = TargetZone.Battlefield}), typeof(RemoveBlocker), false));
        }
        public False_Orders(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
