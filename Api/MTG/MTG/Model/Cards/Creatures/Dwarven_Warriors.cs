using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Activated;
using MTG.Model.Abilities.Static;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Dwarven_Warriors : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=191
        *  
        *  {T}: Target creature with power 2 or less can't be blocked this turn.
        *  
        * Rulings
        * 2004-10-04: The ability can be activated after a creature is blocked, but it has no effect. Once a creature is blocked, it can't be unblocked.
        * 2004-10-04: If you increase the power of the targeted creature after the ability resolves, it still can't be blocked that turn.
        *
        */
        public Dwarven_Warriors() : base()
        {
            MultiverseId = 191;
            Name = "Dwarven Warriors";
            Set(1, 1);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Dwarf);
            Add(SubType.Warrior);
            Add(CardType.Creature);
            Add(new AbilityGenerator(true, typeof(Unblockable), new TargetRequirements(TargetScope.Single, TargetType.Card, new TargetCardRequirements() { HasType = CardType.Creature,PowerValue = 3, PowerComparison = Comparator.Less_Than  }), GamePhase.None));
        }
        public Dwarven_Warriors(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
